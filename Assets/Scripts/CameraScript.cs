using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Rigidbody2D rb;

    public float moveSpeed = 40f;
    Vector2 movement;

    private Vector2 yPosition;
    private Vector2 xPosition;

    private bool freezeX = false;
    private bool freezeY = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

        if(freezeX == false) //If the camera isn't frozen then make horizontal camera movement available
        {
            movement.x = Input.GetAxisRaw("Horizontal");
        }

        if(freezeX == true) //If camera is frozen then freeze it
        {
            movement.x = 0;
        }
        
        if(freezeY == false) //If the camera isn't frozen then make vertical camera movement available
        {
            movement.y = Input.GetAxisRaw("Vertical");
        }
        
        if(freezeY == true) //If camera is frozen then freeze it
        {
            movement.y = 0;
        }



        


        if (transform.position.x >= 5.47) //Freezes the x position of the camera when scrolling to the end of the rightmost position
        {
            freezeX = true;
        }


        if(transform.position.x <= -5.47) //Freezes the x position of the camera when scrolling to the end of the leftmost position
        {
            freezeX = true;
        }


        if (transform.position.y <= -8.96) //Freezes the y position of the camera when scrolling to the end of the downMost position
        {
            freezeY = true;
        }






        /*

        if (transform.position.y > -9.02)
        {
            freezeY = false;
        }


        if (transform.position.x < 10.3)
        {
            freezeX = false;
        }


        if(transform.position.x > -10.3)
        {
            freezeX = false;
        }

        
    */







        if (transform.position.x > 5.47 && Input.GetKey(KeyCode.A))
        {
            freezeX = false;
        }

        if(transform.position.x < -5.47 && Input.GetKey(KeyCode.D))
        {
            freezeX = false;
        }

        if(transform.position.y > -9.1 && Input.GetKey(KeyCode.W))
        {
            freezeY = false;
        }


    }
}
