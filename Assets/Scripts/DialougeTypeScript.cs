using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialougeTypeScript : MonoBehaviour
{
    public static DialougeTypeScript instance = null;

    TextMeshProUGUI dialouge_box;
    public GameObject dialougeBox;
    public GameObject dialougePanel;

    public float wait_time = 0.1f;
    private bool isRunning = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        dialouge_box = dialougeBox.GetComponentInChildren<TextMeshProUGUI>();
    }
    
    public void WriteText(string dialouge)
    {
        if(!isRunning)
            StartCoroutine(TypeDialouge(dialouge));
    }

    IEnumerator TypeDialouge(string dialouge)
    {
        isRunning = true;
        dialougePanel.SetActive(true);
        dialouge_box.text = "";
        Time.timeScale = 0;
        foreach(char c in dialouge)
        {
            dialouge_box.text += c;
            yield return new WaitForSecondsRealtime(wait_time);
        }
        yield return new WaitForSecondsRealtime(dialouge.Length * 0.05f);
        dialougePanel.SetActive(false);
        Time.timeScale = 1;
        isRunning = false;

    }
}
