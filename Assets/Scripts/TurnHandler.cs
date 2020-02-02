using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TurnHandler : MonoBehaviour
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

    bool boredText1 = false;
    bool boredText2 = false;
    [SerializeField]
    Text textPanelText;
    TextWriter textWriterScript;

    public static int enemyHappiness;
    public static int enemyBoredom;
    public static int playerHappiness;
    public static int playerBoredom;

    public static bool enemyTurn = false;
    int num = 0;
    int num1 = 0;
    int num2 = 0;
    void Start()
    {
        textWriterScript = textPanelText.GetComponent<TextWriter>();

        enemyHappiness = Random.Range(1, 99);
        enemyBoredom = Random.Range(1, 99);
        playerBoredom = Random.Range(0, 85);
        playerHappiness = Random.Range(25, 100);
    }

    void Update()
    {
        #region EnemyTurn
        if (enemyTurn == true)
        {

            CloseAllCombat.CloseAll(new List<GameObject>() {combatPanel, itemPanel, regretPanel, values });

            if (num == 0)
            {
                int randnum = Random.Range(1, 4);
                if (randnum == 1)
                {
                    textWriterScript.Initialiser(Enemy.enemy.name + " talks about the weather, you feel yourself becoming less interested in the confrontation");
                    playerBoredom += 10;
                    num++;
                }
                else if (randnum == 2)
                {
                    textWriterScript.Initialiser(Enemy.enemy.name + " humms a song, you feel a little happier");
                    playerHappiness += 10;
                    enemyHappiness += 5;
                    num++;
                    
                }
                else if (randnum == 3)
                {
                    textWriterScript.Initialiser(Enemy.enemy.name + " Aggresively bites towards you");
                    playerBoredom -= 10;
                    playerHappiness -= 15;
                    
                    num++;
                }
                else if (randnum == 4)
                {
                    textWriterScript.Initialiser(Enemy.enemy.name + " Strikes a pose, Incredible!");
                    playerBoredom -= 10;
                    enemyHappiness += 5;
                    enemyBoredom += 5;
                    playerHappiness += 10;
                    num++;
                }
            }

            if (textWriterScript.finished == true)
            {
                enemyTurn = false;
                BetweenTurns.betweenTurn = false;
                TextContinue.myContinue = false;

                combatPanel.SetActive(true);
                values.SetActive(true);
                textPanel.SetActive(false);
                num = 0;
                
            }
        }
        #endregion

        #region SwitchScen
        //BORED
        if ((textPanelText.text == "The enemy got bored and fell asleep... You walk away dejectedly" || textPanelText.text == "You grow tired of the stale battle and leave to find better things to do") && TextContinue.myContinue == true)
        {
            SceneManager.LoadScene("Scen1");
        }
        //BAD ENDING
        if ((textPanelText.text == "The enemy is very sad, so he runs away...."|| textPanelText.text == "You become very sad, while running away you swear to remember this moment....") && TextContinue.myContinue == true)
        {
            SceneManager.LoadScene("Scen1");

        }
        //GOOD ENDINGS
        if ((textPanelText.text == "The enemy hops around with glee:) You and " + Enemy.enemy.name + " form a bond" || textPanelText.text == "You Ignore the enemy as you continue your jorney with newfound enthusiasm") && TextContinue.myContinue == true)
        {
            SceneManager.LoadScene("Scen1");

        }
        #endregion

        #region Make It Enemy Turn
        if (textWriterScript.finished == true && BetweenTurns.betweenTurn == true)
        {
            enemyTurn = true;
            
        }
        #endregion

        if (Input.GetKeyDown(KeyCode.B))
        {
            playerHappiness += 10;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            enemyHappiness += 10;
        }

        if (enemyBoredom >= 100 && enemyTurn == false && BetweenTurns.betweenTurn == false)
        {
            InteractiveItem.crocDefeated = true;

            enemyBoredom = 1;
            CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });

            textPanel.SetActive(true);
            textWriterScript.Initialiser("The enemy got bored and fell asleep... You walk away dejectedly");

        }
        else if (enemyBoredom <= 0 && enemyTurn == false && boredText1 == false && BetweenTurns.betweenTurn == false)
        {
            InteractiveItem.crocDefeated = true;

            if (num1 == 0)
            {
                num1++;
                CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });
                textPanel.SetActive(true);
                textWriterScript.Initialiser("The enemy is Super Invested and Pumped for the battle");
            }

            if (textWriterScript.finished == true)
            {
                enemyTurn = false;
                BetweenTurns.betweenTurn = false;
                TextContinue.myContinue = false;

                combatPanel.SetActive(true);
                values.SetActive(true);
                textPanel.SetActive(false);
                boredText1 = true;

            }
        }
        else if (playerBoredom >= 100 && enemyTurn == false && BetweenTurns.betweenTurn == false)
        {
            InteractiveItem.crocDefeated = true;

            playerBoredom = 1;

            CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });

            textPanel.SetActive(true);
            textWriterScript.Initialiser("You grow tired of the stale battle and leave to find better things to do");
        }
        else if (playerBoredom <= 0 && enemyTurn == false && boredText2 == false && BetweenTurns.betweenTurn == false)
        {
            InteractiveItem.crocDefeated = true;

            if (num2 == 0)
            {
                num2++;
                CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });
                textPanel.SetActive(true);
                textWriterScript.Initialiser("You're Fucking Hyped for the battle");
            }

            if (textWriterScript.finished == true)
            {
                enemyTurn = false;
                BetweenTurns.betweenTurn = false;
                TextContinue.myContinue = false;

                combatPanel.SetActive(true);
                values.SetActive(true);
                textPanel.SetActive(false);
                boredText2 = true;
            }
        }
        else if (enemyHappiness <= 0 && BetweenTurns.betweenTurn == false)
        {
            CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });

            textPanel.SetActive(true);
            textWriterScript.Initialiser("The enemy is very sad, so he runs away....");
            InteractiveItem.crocDefeated = true;

        }
        else if (playerHappiness <= 0 && BetweenTurns.betweenTurn == false)
        {
            CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });

            textPanel.SetActive(true);
            textWriterScript.Initialiser("You become very sad, while running away you swear to remember this moment....");
            InteractiveItem.crocDefeated = true;

        }
        else if (enemyHappiness >= 100 && BetweenTurns.betweenTurn == false)
        {
            CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });

            textPanel.SetActive(true);
            textWriterScript.Initialiser("The enemy hops around with glee:) You and " + Enemy.enemy.name + " form a bond");

            InteractiveItem.crocDefeated = true;
        }
        else if (playerHappiness >= 100 && BetweenTurns.betweenTurn == false)
        {

            CloseAllCombat.CloseAll(new List<GameObject>() { combatPanel, itemPanel, regretPanel, values });

            textPanel.SetActive(true);
            textWriterScript.Initialiser("You Ignore the enemy as you continue your jorney with newfound enthusiasm");

            InteractiveItem.crocDefeated = true;
        }


    }
}
