using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }

        Vector3 mousepos = Input.mousePosition;
        Camera cam = Camera.main;
        gameObject.transform.position = new Vector3(cam.ScreenToWorldPoint(mousepos).x, cam.ScreenToWorldPoint(mousepos).y, 0) ;
    }

}
