using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausePanel.activeSelf == false)
            {
                PausePanel.SetActive(true);
            }
            else
            {
                PausePanel.SetActive(false);
            }
        }

        // if (Input.GetKeyDown(KeyCode.Escape) && PausePanel.activeSelf == false)
        // {
        //     PausePanel.SetActive(true);
        // }

        // if (Input.GetKeyDown(KeyCode.Escape) && PausePanel.activeSelf == true)
        // {
        //     PausePanel.SetActive(false);
        // }
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
    }
}
