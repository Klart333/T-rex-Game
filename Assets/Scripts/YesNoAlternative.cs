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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextWriter.finished == true)
        {
            gameObject.SetActive(true);
        }

        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(YesNo);
    }
    void YesNo()
    {
        if (gameObject.name == "Yes")
        {

            SceneManager.LoadScene("CombatScene");
        }
        else if (gameObject.name == "No")
        {
            mainTextPanel.SetActive(false);
        }
    }
}
