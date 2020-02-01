using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField]
    GameObject interact;
    bool facingUp = false;
    bool facingDown = false;
    bool facingLeft = false;
    bool facingRight = false;

    void Update()
    {

        #region SetActive
        if (facingRight && Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(interact, new Vector3(gameObject.transform.position.x + gameObject.transform.localScale.x/2, gameObject.transform.position.y, 0), Quaternion.identity);

        }
        if (facingLeft && Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(interact, new Vector3(gameObject.transform.position.x - gameObject.transform.localScale.x /2, gameObject.transform.position.y, 0), Quaternion.identity);


        }
        if (facingUp && Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(interact, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + gameObject.transform.localScale.y/2, 0), Quaternion.identity);


        }
        if (facingDown && Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(interact, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - gameObject.transform.localScale.y/2, 0), Quaternion.identity);


        }
        #endregion

        #region Facing
        if (Input.GetKeyDown(KeyCode.W))
        {
            facingUp = true;
            facingDown = false;
            facingLeft = false;
            facingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            facingUp = false;
            facingDown = true;
            facingLeft = false;
            facingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            facingUp = false;
            facingDown = false;
            facingLeft = true;
            facingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            facingUp = false;
            facingDown = false;
            facingLeft = false;
            facingRight = true;
        }

        #endregion
    }




}

