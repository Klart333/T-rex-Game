using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoPlacement : MonoBehaviour
{
    [SerializeField]
    GameObject mainDino;
    void Start()
    {
        Instantiate(mainDino, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(Enemy.enemy, new Vector3(10, 10, 0), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
