using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject ui;
    public GameObject uiEnd;
    public void StartTheGame()
    {
        ui.SetActive(false);
    }

    public void FinishTheGame()
    {
        Application.Quit();
    }
}
