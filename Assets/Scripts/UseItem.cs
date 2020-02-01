using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UseItem : MonoBehaviour
{
    [SerializeField]
    GameObject mainItemPanel;
    [SerializeField]
    GameObject regret;

    Image item;

    bool hasClicked = false;
    float timer;
    void Start()
    {
        item = GetComponent<Image>();
    }

    void Update()
    {
        if (hasClicked == false)
        {
            Button btn = GetComponent<Button>();
            btn.onClick.AddListener(ItemUse);
            hasClicked = true;
        }
        timer += Time.deltaTime;
        if (timer >= 99999999999999999999999f)
        {
            hasClicked = false;
            timer = 0;
        }
        
    }

    void ItemUse()
    {
        print("the item is " + Resources.Load<Sprite>(item.sprite.name));
        GameObject sprite = Instantiate<GameObject>(Resources.Load<GameObject>(item.sprite.name + "GO"), new Vector3(1000, 1000, -9990), Quaternion.identity);

        mainItemPanel.transform.localScale = new Vector3(mainItemPanel.transform.localScale.x / 25, mainItemPanel.transform.localScale.y, 0);
        regret.SetActive(true);
    }
}
