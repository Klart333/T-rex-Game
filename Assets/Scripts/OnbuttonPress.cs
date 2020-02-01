using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnbuttonPress : MonoBehaviour
{
    [SerializeField]
    GameObject topLeft;
    [SerializeField]
    GameObject topRight;
    [SerializeField]
    GameObject bottomLeft;
    [SerializeField]
    GameObject bottomRight;
    [SerializeField]
    GameObject mainPanel;
    [SerializeField]
    GameObject itemHud;

    Image topLeftImage;
    Image topRightImage;
    Image bottomRightImage;
    Image bottomLeftImage;
    void Start()
    {
        Button theButton = gameObject.GetComponent<Button>();
        theButton.onClick.AddListener(OnPressed);

        topLeftImage = topLeft.GetComponent<Image>();
        topRightImage = topRight.GetComponent<Image>();
        bottomRightImage = bottomRight.GetComponent<Image>();
        bottomLeftImage = bottomLeft.GetComponent<Image>();
    }

    void OnPressed()
    {
        if (gameObject.name == "Flee")
        {
            new WaitForSeconds(0.5f);

            print("You Ran Away");

            mainPanel.SetActive(false);
            itemHud.SetActive(false);

        }
        else if (gameObject.name == "Talk")
        {
            new WaitForSeconds(0.5f);

            topLeftImage.sprite = Resources.Load<Sprite>("SubActions/Flatter");
            topLeft.name = "Flatter";
            topRightImage.sprite = Resources.Load<Sprite>("SubActions/Insult");
            topRight.name = "Insult";
            bottomLeftImage.sprite = Resources.Load<Sprite>("SubActions/Ignore");
            bottomLeft.name = "Ignore";
            bottomRightImage.sprite = Resources.Load<Sprite>("SubActions/GoBack");
            bottomRight.name = "GoBack";
        }
        else if (gameObject.name == "Act")
        {
            new WaitForSeconds(0.5f);

            topLeftImage.sprite = Resources.Load<Sprite>("SubActions/Roar");
            topLeft.name = "Roar";
            topRightImage.sprite = Resources.Load<Sprite>("SubActions/Dance");
            topRight.name = "Dance";
            bottomLeftImage.sprite = Resources.Load<Sprite>("SubActions/Sneer");
            bottomLeft.name = "Sneer";
            bottomRightImage.sprite = Resources.Load<Sprite>("SubActions/GoBack");
            bottomRight.name = "GoBack";
        }
        else if (gameObject.name == "Item")
        {
            new WaitForSeconds(0.5f);

            if (itemHud.activeSelf == true)
            {
                itemHud.SetActive(false);
            }
            else if (itemHud.activeSelf == false)
            {
                itemHud.SetActive(true);
            }
        }
        else if (gameObject.name == "GoBack")
        {
            GoBack();
        }
 
    }
    void GoBack()
    {
        topLeftImage.sprite = Resources.Load<Sprite>("Actions/Item");
        topLeft.name = "Item";
        topRightImage.sprite = Resources.Load<Sprite>("Actions/Talk");
        topRight.name = "Talk";
        bottomLeftImage.sprite = Resources.Load<Sprite>("Actions/Act");
        bottomLeft.name = "Act";
        bottomRightImage.sprite = Resources.Load<Sprite>("Actions/Flee");
        bottomRight.name = "Flee";
    }
}
