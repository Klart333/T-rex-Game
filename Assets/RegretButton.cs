using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RegretButton : MonoBehaviour
{
    [SerializeField]
    GameObject itemMainHud;
    void Start()
    {
        
    }

    void Update()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Regret);
    }

    void Regret()
    {
        itemMainHud.transform.localScale = new Vector3(1, 1, 1);
        gameObject.SetActive(false);
    }
}
