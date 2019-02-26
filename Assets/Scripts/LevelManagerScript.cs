using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript instance = null;
    
    public bool isWinter = true;
    public List<GameObject> summerObjectList;
    public List<GameObject> winterObjectList;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        SeasonChangeButtonScript.instance.OnSeasonChange.AddListener(OnSeasonChangeListener);
    }

    // Update is called once per frame
    void Update()
    {
        
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
