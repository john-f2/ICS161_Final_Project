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
        StartCoroutine(TypeDialouge(dialouge));
    }

    IEnumerator TypeDialouge(string dialouge)
    {
        dialougePanel.SetActive(true);
        foreach(char c in dialouge)
        {
            dialouge_box.text += c;
            yield return new WaitForSeconds(wait_time);
        }
        yield return new WaitForSeconds(dialouge.Length * 0.2f);
        dialougePanel.SetActive(false);

    }
}
