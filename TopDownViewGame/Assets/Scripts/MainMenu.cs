using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int lives = 5;
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelOne");
        PlayerPrefs.SetInt("lives", lives);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
