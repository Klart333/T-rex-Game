using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFinished : MonoBehaviour
{
    [SerializeField]
    GameObject no;
    [SerializeField]
    GameObject yes;
    

    void Update()
    {
        if (GetComponent<TextWriter>().finished)
        {
            yes.SetActive(true);
            no.SetActive(true);
        }
    }
}
