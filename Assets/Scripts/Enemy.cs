using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("the enemy is: " + enemy);

        if (enemy == null)
        {
            enemy = Resources.Load<GameObject>("TheCroc");
        }
    }
}
