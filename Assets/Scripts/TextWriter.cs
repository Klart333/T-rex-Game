using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextWriter : MonoBehaviour
{
    Text txt;
    float timer = 0;
    string sentence = "";
    string ogSentence = "";
    void Start()
    {
        txt = GetComponent<Text>();
        
    }

    void Awake()
    {
        print("AAA");
        ogSentence = txt.text;
        foreach (char item in ogSentence)
        {
            sentence += item;
            while (timer <= 1)
            {
                timer += Time.deltaTime;
            }
            if (timer >= 1)
            {
                txt.text = sentence;
                timer = 0;
            }

        }
    }
    
}
