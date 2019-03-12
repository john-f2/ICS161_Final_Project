using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public void OnMainMenuButtonClicked()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }
}
