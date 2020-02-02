using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerValues : MonoBehaviour
{
    Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Boredom")
        {
            txt.text = "Boredom: " + TurnHandler.playerBoredom.ToString();
        }
        else if (gameObject.name == "Happiness")
        {
            txt.text = "Happiness: " + TurnHandler.playerHappiness.ToString();
        }

    }
}
