using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DinoReplacer : MonoBehaviour
{
    
    Vector3 Lastposition;
    Scene ogScen;
    Scene newScene;

    static int num = 0;
    void Start()
    {
        if (num == 0)
        {
            num++;
            Lastposition = gameObject.transform.position;
        }
        ogScen = SceneManager.GetActiveScene();
    }
    void Update()
    {




        if (newScene.buildIndex != ogScen.buildIndex)
        {
            if (SceneManager.GetActiveScene().name != "CombatScene")
            {

                gameObject.transform.position = Lastposition;
                print(Lastposition);

            }
        }
        else
        {
            Lastposition = gameObject.transform.position;
            
        }

        newScene = SceneManager.GetActiveScene();
    }
}
