﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    private GameObject move;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                move.GetComponent<MouseLookAt>().enabled = true;
            }
            else
            {
                Pause();
                move.GetComponent<MouseLookAt>().enabled = false;
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void LoadHelp()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Help");
    }
    
    public void LoadWorld()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("world");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
