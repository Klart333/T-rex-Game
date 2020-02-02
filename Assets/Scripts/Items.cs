using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Items : MonoBehaviour
{
    public static int amountOfSaft = 1;
    public static int amountOfValnut = 1;
    public static int amountOfRolex = 3;

    [SerializeField]
    GameObject itemSlot1;
    [SerializeField]
    GameObject itemSlot2;
    [SerializeField]
    GameObject itemSlot3;

    Sprite saft;
    Sprite valnut;
    Sprite rolex;

    Image itemSlot1Image;
    Image itemSlot2Image;
    Image itemSlot3Image;
    void Start()
    {
        saft = Resources.Load<Sprite>("Saft");
        valnut = Resources.Load<Sprite>("Valnut");
        rolex = Resources.Load<Sprite>("Rolex");

        itemSlot1Image = itemSlot1.GetComponent<Image>();
        itemSlot2Image = itemSlot2.GetComponent<Image>();
        itemSlot3Image = itemSlot3.GetComponent<Image>();
    }

    void Update()
    {
        if (itemSlot1Image.sprite == null)
        {
            if (amountOfSaft != 0 && itemSlot1Image.sprite != saft && itemSlot2Image.sprite != saft && itemSlot3Image.sprite != saft)
            {

                itemSlot1Image.sprite = saft;
            }
            else if (amountOfValnut != 0 && itemSlot1Image.sprite != valnut && itemSlot2Image.sprite != valnut && itemSlot3Image.sprite != valnut)
            {
                itemSlot1Image.sprite = valnut;
            }
            else if (amountOfRolex != 0 && itemSlot1Image.sprite != rolex && itemSlot2Image.sprite != rolex && itemSlot3Image.sprite != rolex)
            {
                itemSlot1Image.sprite = rolex;
                print(rolex);
            }
            else
            {
                itemSlot1Image.color = new Vector4(0, 0, 0, 0);
            }
        }
        if (itemSlot2Image.sprite == null)
        {

            if (amountOfSaft != 0 && itemSlot1Image.sprite != saft && itemSlot2Image.sprite != saft && itemSlot3Image.sprite != saft)
            {
                itemSlot2Image.sprite = saft;
            }
            else if (amountOfValnut != 0 && itemSlot1Image.sprite != valnut && itemSlot2Image.sprite != valnut && itemSlot3Image.sprite != valnut)
            {
                itemSlot2Image.sprite = valnut;
            }
            else if (amountOfRolex != 0 && itemSlot1Image.sprite != rolex && itemSlot2Image.sprite != rolex && itemSlot3Image.sprite != rolex)
            {
                itemSlot2Image.sprite = rolex;
            }
            else
            {
                itemSlot2Image.color = new Vector4(0, 0, 0, 0);
            }

        }
        if (itemSlot3Image.sprite == null)
        {
            if (amountOfSaft != 0 && itemSlot1Image.sprite != saft && itemSlot2Image.sprite != saft && itemSlot3Image.sprite != saft)
            {
                itemSlot3Image.sprite = saft;
            }
            else if (amountOfValnut != 0 && itemSlot1Image.sprite != valnut && itemSlot2Image.sprite != valnut && itemSlot3Image.sprite != valnut)
            {
                itemSlot3Image.sprite = valnut;
            }
            else if (amountOfRolex != 0 && itemSlot1Image.sprite != rolex && itemSlot2Image.sprite != rolex && itemSlot3Image.sprite != rolex)
            {
                itemSlot3Image.sprite = rolex;
            }
            else
            {
                itemSlot3Image.color = new Vector4(0, 0, 0, 0);

            }
        }
    }
}
