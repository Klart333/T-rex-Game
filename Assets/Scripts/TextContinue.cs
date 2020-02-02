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

    public static bool myContinue;
    void Start()
    {

        topLeftImage = topLeft.GetComponent<Image>();
        topRightImage = topRight.GetComponent<Image>();
        bottomRightImage = bottomRight.GetComponent<Image>();
        bottomLeftImage = bottomLeft.GetComponent<Image>();
    }

    void Update()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Continue);
    }

    void Continue()
    {

        myContinue = true;
        print("Continue " + myContinue);
        
    }
}
