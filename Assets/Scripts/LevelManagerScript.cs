using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript instance = null;

    public bool hasArtifact = false;
    public bool isWinter = true;
    public List<GameObject> summerObjectList;
    public List<GameObject> winterObjectList;

    TextMeshProUGUI dialouge_box;
    [SerializeField] protected GameObject dialougeBox;
    [SerializeField] protected GameObject dialougePanel;
    [SerializeField] protected GameObject seasonControl;
    [SerializeField] protected GameObject fadeScreen;
    [SerializeField] protected GameObject goddessText;

    public float wait_time = 0.1f;
    public float fade_speed = 0.5f;
    private bool isRunning = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
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
        seasonControl.GetComponent<SeasonChangeButtonScript>().enabled = false;
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
        if (hasArtifact)
        {
            seasonControl.GetComponent<SeasonChangeButtonScript>().enabled = true;
        }

    }

    public void EndGame()
    {
        if (!isRunning)
        {
            StartCoroutine(EndingSequence());
        }
    }

    IEnumerator EndingSequence()
    {
        isRunning = true;
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1.0f);
        Image fadescreenimage = fadeScreen.GetComponent<Image>();
        var fadescreencolor = fadescreenimage.color;
        while (fadescreencolor.a < 1)
        {
            fadescreencolor.a += fade_speed;
            fadescreenimage.color = fadescreencolor;
            yield return new WaitForSecondsRealtime(0.3f);
        }
        yield return new WaitForSecondsRealtime(2.0f);
        TextMeshProUGUI goddessTextComponent = goddessText.GetComponent<TextMeshProUGUI>();
        string g_text = "Thank you for returning the artifact to me...";
        foreach (char c in g_text)
        {
            goddessTextComponent.text += c;
            yield return new WaitForSecondsRealtime(0.08f);
        }
        yield return new WaitForSecondsRealtime(g_text.Length * 0.03f);
        g_text = "I can now return the flow of seasons to your home...";
        goddessTextComponent.text = "";
        foreach (char c in g_text)
        {
            goddessTextComponent.text += c;
            yield return new WaitForSecondsRealtime(0.08f);
        }
        yield return new WaitForSecondsRealtime(g_text.Length * 0.03f);
        g_text = "Go in peace and enjoy this world.";
        goddessTextComponent.text = "";
        foreach (char c in g_text)
        {
            goddessTextComponent.text += c;
            yield return new WaitForSecondsRealtime(0.08f);
        }
        yield return new WaitForSecondsRealtime(g_text.Length * 0.03f);
        SceneManager.LoadScene("End");
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
