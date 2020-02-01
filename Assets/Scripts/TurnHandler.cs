using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TurnHandler : MonoBehaviour
{
    [SerializeField]
    GameObject combatPanel;
    [SerializeField]
    GameObject itemPanel;
    [SerializeField]
    GameObject textPanel;
    [SerializeField]
    GameObject regretPanel;

    [SerializeField]
    Text textPanelText;
    public static int enemyHappiness;
    public static int enemyBoredom;
    void Start()
    {
        enemyHappiness = Random.Range(1, 99);
        enemyBoredom = Random.Range(1, 99);
    }

    void Update()
    {
        if (textPanelText.GetComponent<TextWriter>().finished == true)
        {
            if (textPanelText.text == "The enemy got bored and fell asleep... You walk away dejectedly")
            {
                print("Changing Scene");
                SceneManager.LoadScene("Scen1");
            }
            else if (true)
            {

            }

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            enemyBoredom += 10;
        }

        if (enemyBoredom >= 100)
        {
            enemyBoredom = 0;
            combatPanel.SetActive(false);
            itemPanel.SetActive(false);
            regretPanel.SetActive(false);

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("The enemy got bored and fell asleep... You walk away dejectedly");

        }
    }
}
