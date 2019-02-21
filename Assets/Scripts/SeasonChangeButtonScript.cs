using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SeasonChangeButtonScript : MonoBehaviour
{
    public static SeasonChangeButtonScript instance = null;

    [SerializeField] protected Sprite winter_sprite;
    [SerializeField] protected Sprite summer_sprite;

    private Image button_image;

    public UnityEvent OnSeasonChange;
     
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        button_image = this.GetComponent<Image>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSeasonChangeButtonClick()
    {
        LevelManagerScript.instance.isWinter = !LevelManagerScript.instance.isWinter;
        OnSeasonChange.Invoke();

        if (LevelManagerScript.instance.isWinter)
        {
            button_image.sprite = winter_sprite;
        }
        else
        {
            button_image.sprite = summer_sprite;
        }
    }
}
