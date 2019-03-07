using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    [SerializeField] protected GameObject controlsPanel;

    public bool controlsUp = false;

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Ariana");
    }

    public void OnControlsButtonClicked()
    {
        controlsUp = !controlsUp;
        if (controlsUp)
        {
            controlsPanel.SetActive(true);
        }
        else
        {
            controlsPanel.SetActive(false);
        }
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }

}
