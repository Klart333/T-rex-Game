using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextContinue : MonoBehaviour
{
    [SerializeField]
    GameObject combat;
    [SerializeField]
    Text theText;

    [SerializeField]
    GameObject topLeft;
    [SerializeField]
    GameObject topRight;
    [SerializeField]
    GameObject bottomLeft;
    [SerializeField]
    GameObject bottomRight;

    Image topLeftImage;
    Image topRightImage;
    Image bottomRightImage;
    Image bottomLeftImage;
    void Start()
    {

        topLeftImage = topLeft.GetComponent<Image>();
        topRightImage = topRight.GetComponent<Image>();
        bottomRightImage = bottomRight.GetComponent<Image>();
        bottomLeftImage = bottomLeft.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Continue);
    }

    void Continue()
    {
        if (theText.GetComponent<TextWriter>().ogSentence != "The enemy got bored and fell asleep... You walk away dejectedly")
        {
            combat.SetActive(true);

            topLeftImage.sprite = Resources.Load<Sprite>("Actions/Item");
            topLeft.name = "Item";
            topRightImage.sprite = Resources.Load<Sprite>("Actions/Talk");
            topRight.name = "Talk";
            bottomLeftImage.sprite = Resources.Load<Sprite>("Actions/Act");
            bottomLeft.name = "Act";
            bottomRightImage.sprite = Resources.Load<Sprite>("Actions/Flee");
            bottomRight.name = "Flee";

            gameObject.SetActive(false);
        }
    }
}
