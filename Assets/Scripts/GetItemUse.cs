using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemUse : MonoBehaviour
{
    [SerializeField]
    GameObject values;
    [SerializeField]
    GameObject combatPanel;
    [SerializeField]
    GameObject itemPanel;
    [SerializeField]
    GameObject textPanel;
    [SerializeField]
    GameObject regretPanel;
    [SerializeField]
    GameObject textPanelText;


    TextWriter textWriterScript;
    void Start()
    {
        textWriterScript = textPanelText.GetComponent<TextWriter>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (gameObject.name == "DinoHitBox")
        {
            
            if (UseItem.theItem != null)
            {
                if (UseItem.theItem == Resources.Load<GameObject>("RolexGO"))
                {
                    Items.amountOfRolex -= 1;
                    UseItem.theItem = null;
                    BetweenTurns.betweenTurn = true;
                    CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, values, regretPanel });

                    textPanel.SetActive(true);
                    textWriterScript.Initialiser("You put on a Rolex, AND FLEX HAARD!!");


                    TurnHandler.playerBoredom -= 20;
                    TurnHandler.playerHappiness += 10;
                    TurnHandler.enemyBoredom -= 40;
                    itemPanel.transform.localScale = new Vector3(1, 1, 1);


                }
                else if (UseItem.theItem.name == "SaftGO")
                {
                    UseItem.theItem = null;
                    Items.amountOfSaft -= 1;
                    BetweenTurns.betweenTurn = true;

                    CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, values, regretPanel });

                    textPanel.SetActive(true);
                    textWriterScript.Initialiser("You drink some Juice, and feel refreshed");

                    TurnHandler.playerBoredom -= 10;
                    TurnHandler.playerHappiness += 5;
                    TurnHandler.enemyBoredom += 20;
                    TurnHandler.enemyHappiness -= 10;
                    itemPanel.transform.localScale = new Vector3(1, 1, 1);

                }
                else if (UseItem.theItem.name == "ValnutGO")
                {
                    UseItem.theItem = null;

                    Items.amountOfValnut -= 1;
                    BetweenTurns.betweenTurn = true;

                    CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, values, regretPanel });

                    textPanel.SetActive(true);
                    textWriterScript.Initialiser("You snack on a nut, it takes a while");

                    TurnHandler.playerBoredom += 10;
                    TurnHandler.playerHappiness += 5;
                    TurnHandler.enemyBoredom += 20;
                    TurnHandler.enemyHappiness -= 5;
                    itemPanel.transform.localScale = new Vector3(1, 1, 1);

                }
            }
        }
        else if (gameObject.name == "EnemyHitBox")
        {
            if (UseItem.theItem != null)
            {
                if (UseItem.theItem.name == "RolexGO")
                {
                    Items.amountOfRolex -= 1;
                    UseItem.theItem = null;
                    BetweenTurns.betweenTurn = true;
                    CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, values, regretPanel });

                    textPanel.SetActive(true);
                    textWriterScript.Initialiser("You give a Rolex to " + Enemy.enemy.name + ", he's not very impressed");


                    TurnHandler.playerBoredom -= 20;
                    TurnHandler.playerHappiness -= 25;
                    TurnHandler.enemyBoredom -= 0;
                    TurnHandler.enemyHappiness -= 10;

                    itemPanel.transform.localScale = new Vector3(1, 1, 1);
                }
                else if (UseItem.theItem.name == "SaftGO")
                {
                    UseItem.theItem = null;
                    Items.amountOfSaft -= 1;
                    BetweenTurns.betweenTurn = true;

                    CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, values, regretPanel });

                    textPanel.SetActive(true);
                    textWriterScript.Initialiser("You give " + Enemy.enemy.name + " some juice to drink... He doesn't like juice");

                    TurnHandler.playerBoredom += 10;
                    TurnHandler.playerHappiness -= 15;
                    TurnHandler.enemyBoredom += 20;
                    TurnHandler.enemyHappiness -= 15;
                    itemPanel.transform.localScale = new Vector3(1, 1, 1);

                }
                else if (UseItem.theItem.name == "ValnutGO")
                {
                    UseItem.theItem = null;

                    Items.amountOfValnut -= 1;

                    BetweenTurns.betweenTurn = true;

                    CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, values, regretPanel });

                    textPanel.SetActive(true);
                    textWriterScript.Initialiser("You Give a snack to " + Enemy.enemy.name + ", he is super happy!");

                    TurnHandler.playerBoredom += 10;
                    TurnHandler.playerHappiness -= 5;
                    TurnHandler.enemyBoredom -= 20;
                    TurnHandler.enemyHappiness += 15;
                    itemPanel.transform.localScale = new Vector3(1, 1, 1);

                }
            }
        }
    }
}
