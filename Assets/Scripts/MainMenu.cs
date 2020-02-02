using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int num = 0;
    // Update  called once per frame
    void Update()
    {
        if (num == 0)
        {
            num++;

            Button btn = GetComponent<Button>();
            btn.onClick.AddListener(AAAA);
        }
    }
    void AAAA()
    {
        if (gameObject.name == "Start")
        {
            SceneManager.LoadScene("Scen1");
        }
        else if (gameObject.name == "Quit")
        {
            Application.Quit();
        }
    }

}
