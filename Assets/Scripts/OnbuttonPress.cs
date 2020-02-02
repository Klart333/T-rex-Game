using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OnbuttonPress : MonoBehaviour
{
    [SerializeField]
    GameObject values;
    [SerializeField]
    GameObject topLeft;
    [SerializeField]
    GameObject topRight;
    [SerializeField]
    GameObject bottomLeft;
    [SerializeField]
    GameObject bottomRight;
    [SerializeField]
    GameObject mainCombatPanel;
    [SerializeField]
    GameObject itemHud;
    [SerializeField]
    GameObject textPanel;
    [SerializeField]
    Text textPanelText;
    [SerializeField]
    GameObject regret;

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


            SceneManager.LoadScene("Scen1");

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
        else if (gameObject.name == "Dance")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });
            
            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You do a DAANCE!! Croc is Very Impressed");
            TurnHandler.enemyBoredom -= 10;
            TurnHandler.enemyHappiness += 5;
            TurnHandler.playerHappiness += 8;
        }
        else if (gameObject.name == "Flatter")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You Flatter " + Enemy.enemy.name + ". He Smiles Gleefully back");

            TurnHandler.enemyHappiness += 15;
            TurnHandler.enemyBoredom -= 5;
            TurnHandler.playerBoredom += 5;
            TurnHandler.playerHappiness -= 5;
        }
        else if (gameObject.name == "Ignore")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You Ignore the dinosaur, he seems sad and lost...");

            TurnHandler.playerBoredom += 15;
            TurnHandler.enemyBoredom -= 10;
            TurnHandler.enemyHappiness -= 15;
        }
        else if (gameObject.name == "Insult")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You comment on how the enemy looks like he was a 3-year olds first drawing");

            TurnHandler.playerBoredom -= 10;
            TurnHandler.enemyBoredom -= 20;
            TurnHandler.enemyHappiness -= 10;
        }
        else if (gameObject.name == "Roar")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("RRRRAAAAAAAAAAAAAAAWWWWWWWWWWWWRRRRR!!!");

            TurnHandler.playerHappiness += 10;
            TurnHandler.enemyBoredom -= 30;
            
        }
        else if (gameObject.name == "Sing")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You sing, the enemy struggles to hold back his laughter");

            TurnHandler.playerBoredom -= 5;
            TurnHandler.playerHappiness -= 15;
            TurnHandler.enemyBoredom -= 20;
            TurnHandler.enemyHappiness += 15;
        }
        else if (gameObject.name == "Smile")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You smile towards the dinosaur, He gladly smiles back");

            TurnHandler.playerBoredom += 15;
            TurnHandler.playerHappiness += 10;
            TurnHandler.enemyBoredom -= 10;
            TurnHandler.enemyHappiness += 10;
        }
        else if (gameObject.name == "Sneer")
        {
            BetweenTurns.betweenTurn = true;
            CloseAllCombat.CloseAll(new List<GameObject>() { mainCombatPanel, itemHud, values, regret });

            textPanel.SetActive(true);
            textPanelText.GetComponent<TextWriter>().Initialiser("You sneer at the " + Enemy.enemy.name + ", his eyes start watering...");

            TurnHandler.playerBoredom -= 20;
            TurnHandler.playerHappiness += 10;
            TurnHandler.enemyBoredom -= 40;
            TurnHandler.enemyHappiness -= 25;
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
