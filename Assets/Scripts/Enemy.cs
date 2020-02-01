using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int num = 0;
    public static GameObject enemy;
    public static GameObject enemy2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy != null && num == 0)
        {
            enemy2 = enemy;
            num++;
        }
        print("the enemy is: " + enemy2);
    }
}
