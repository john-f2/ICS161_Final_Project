using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript instance = null;
    
    public bool isWinter = true;
    public List<GameObject> summerObjectList;
    public List<GameObject> winterObjectList;

    TextMeshProUGUI dialouge_box;
    public GameObject dialougeBox;
    public GameObject dialougePanel;

    public float wait_time = 0.1f;
    private bool isRunning = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
        dialouge_box = dialougeBox.GetComponentInChildren<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        SeasonChangeButtonScript.instance.OnSeasonChange.AddListener(OnSeasonChangeListener);
    }

    public void WriteText(string dialouge)
    {
        if (!isRunning)
            StartCoroutine(TypeDialouge(dialouge));
    }

    IEnumerator TypeDialouge(string dialouge)
    {
        isRunning = true;
        dialougePanel.SetActive(true);
        dialouge_box.text = "";
        Time.timeScale = 0;
        foreach (char c in dialouge)
        {
            dialouge_box.text += c;
            yield return new WaitForSecondsRealtime(wait_time);
        }
        yield return new WaitForSecondsRealtime(dialouge.Length * 0.01f);
        dialougePanel.SetActive(false);
        Time.timeScale = 1;
        isRunning = false;

    }

    void OnSeasonChangeListener()
    {
        if(isWinter)
        {
            foreach(GameObject i in winterObjectList)
            {
                i.SetActive(true);
            }
            foreach(GameObject i in summerObjectList)
            {
                i.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject i in summerObjectList)
            {
                i.SetActive(true);
            }
            foreach (GameObject i in winterObjectList)
            {
                i.SetActive(false);
            }
        }
    }
}
