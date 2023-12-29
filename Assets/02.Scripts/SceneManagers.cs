using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void GameStartBtn()
    {
        SceneManager.LoadScene("03.BakerStreets");
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadScene("02.MainMenu");
    }

    public void RetryBtn()
    {
        SceneManager.LoadScene("03.BakerStreets");
        Time.timeScale = Time.deltaTime;
    }

    public void ExitBtn()
    {
        Application.Quit();
    }
}
