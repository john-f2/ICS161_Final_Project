﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pausePanel;
    public GameObject screenPanel;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuToggle();
        }
    }

    public void PauseMenuToggle()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            screenPanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            screenPanel.SetActive(false);
        }
    }
    public void OnMainMenuButtonClicked()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }
}
