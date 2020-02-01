using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteractiveItem : MonoBehaviour
{
    int num = 0;
    [SerializeField]
    GameObject txt;
    [SerializeField]
    Text txtText;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "InteractHitBox")
        {
            txt.SetActive(true);
            txtText.GetComponent<TextWriter>().Initialiser("Hey Buddy! Wanna fight!?");
        }
    }

}
