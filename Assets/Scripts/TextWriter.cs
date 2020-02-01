using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextWriter : MonoBehaviour
{
    public static bool finished = false;
    public float letterPause = 0.1f;
    Text txt;
    float timer = 0;
    string sentence = "";
    string ogSentence = "";
    void Start()
    {
        txt = GetComponent<Text>();
        ogSentence = txt.text;
        txt.text = "";
        StartCoroutine(Writer());
    }
    private void Update()
    {
        if (sentence == ogSentence)
        {
            finished = true;
        }
        else
        {
            finished = false;
        }
    }

    IEnumerator Writer()
    {
        
        foreach (char item in ogSentence.ToCharArray())
        {
            txt.text += item;
            sentence += item;
            yield return new WaitForSeconds(letterPause);
        }

    }
    
}
