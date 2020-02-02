using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAllCombat : MonoBehaviour
{

    public static void CloseAll(List<GameObject> closeList)
    {

        foreach (GameObject value in closeList)
        {
            value.SetActive(false);
        }
    }
}
