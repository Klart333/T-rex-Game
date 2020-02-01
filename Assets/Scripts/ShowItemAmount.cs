using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowItemAmount : MonoBehaviour
{
    Text txt;
    Image parent;
    void Start()
    {
        txt = GetComponent<Text>();
        parent = transform.GetComponentInParent<Image>();

    } 

    void Update()
    {

        if (parent.sprite != null)
        {
            switch (parent.sprite.name)
            {
                case "Rolex":
                    txt.text = Items.amountOfRolex.ToString();
                    break;
                case "Valnut":
                    txt.text = Items.amountOfValnut.ToString();
                    break;
                case "Saft":
                    txt.text = Items.amountOfSaft.ToString();
                    break;
                default:
                    txt.text = "";
                    break;
            }
        }
        else
        {
            txt.text = "";
        }

    }
}
