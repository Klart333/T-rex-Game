using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class YesNoAlternative : MonoBehaviour
{
    [SerializeField]
    GameObject mainTextPanel;
    [SerializeField]
    GameObject mainCombatPanel;
    [SerializeField]
    Text mainTextPanelText;
    int num = 0;
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Scen1")
        {
            num = 0;
        }

        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(YesNo);
    }
    void YesNo()
    {
        if (gameObject.name == "Yes" && num == 0)
        {
            num++;
            Enemy.enemy = Resources.Load<GameObject>(Enemy.enemy.name);
            print(Resources.Load<GameObject>(Enemy.enemy.name) + " AAAAAAAAAAAAAAAAAA");

            SceneManager.LoadScene("CombatScene");
        }
        else if (gameObject.name == "No")
        {
            mainTextPanel.SetActive(false);
        }
    }
}
