using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public float moveSpeed = 40f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator anim;


    void Start()
    {

    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude); 
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

    }

}
