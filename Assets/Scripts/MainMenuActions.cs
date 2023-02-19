using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    
    public void OnClickPlay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Gimnasio", LoadSceneMode.Single);
    }

    public void OnClickMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void OnClickExitGame()
    {
        Application.Quit();
    }

}
