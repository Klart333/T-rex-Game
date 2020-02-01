using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextWriter : MonoBehaviour
{

    public bool finished = false;
    public float letterPause = 0.1f;
    Text txt;
    string sentence = "";
    public string ogSentence = "";

    public void Initialiser(string text)
    {
        ogSentence = text;
        sentence = "";
        finished = false;
        txt = GetComponent<Text>();
        txt.text = "";
        StartCoroutine(Writer());
    }
    private void Update()
    {
       
        if (sentence == ogSentence)
        {
            
            finished = true;

        }
        else if(sentence != ogSentence)
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
