using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject ui;
    public GameObject uiEnd;

    public void StartTheGame()
    {
        ui.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ui.SetActive(false);
        }
    }

    public void FinishTheGame()
    {
        Application.Quit();
    }
}
