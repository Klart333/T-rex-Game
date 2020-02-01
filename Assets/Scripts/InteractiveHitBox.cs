using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]

public class InteractiveHitBox : MonoBehaviour
{
    BoxCollider2D box2D;
    void Start()
    {
        box2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        box2D = GetComponent<BoxCollider2D>();
        box2D.isTrigger = true;


        Destroy(gameObject, 0.05f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            GameObject gm = collision.gameObject;
            Enemy.enemy = gm;
        }

    }
}
