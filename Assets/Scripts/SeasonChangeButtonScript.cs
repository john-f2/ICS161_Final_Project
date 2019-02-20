using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeasonChangeButtonScript : MonoBehaviour
{
    private bool isWinter = true;

    [SerializeField] protected Sprite winter_sprite;
    [SerializeField] protected Sprite summer_sprite;

    private Image button_image;

    void Awake()
    {
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
        isWinter = !isWinter;

        if (isWinter)
        {
            button_image.sprite = winter_sprite;
        }
        else
        {
            button_image.sprite = summer_sprite;
        }
    }
}
