using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoPlacement : MonoBehaviour
{
    [SerializeField]
    GameObject mainDino;
    void Start()
    {
        mainDino = Instantiate(mainDino, new Vector3(-7.7f, 0.6f, 0), Quaternion.identity);
        mainDino.GetComponent<SpriteRenderer>().flipX = true;
        mainDino.transform.localScale = new Vector3(8, 8, 0);
        GameObject other = Instantiate(Resources.Load<GameObject>("TheCroc"), new Vector3(8, 3, 0), Quaternion.identity);
        other.transform.localScale = new Vector3(4, 4, 0);
    }

    void Update()
    {
        
    }
}
