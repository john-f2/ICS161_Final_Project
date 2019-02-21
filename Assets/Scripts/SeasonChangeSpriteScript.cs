using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SeasonChangeSpriteScript : MonoBehaviour
{
    [SerializeField] protected Sprite winter_sprite;
    [SerializeField] protected Sprite summer_sprite;

    private SpriteRenderer m_spriterenderer;

    void Awake()
    {
        m_spriterenderer = this.GetComponent<SpriteRenderer>();
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
        if (LevelManagerScript.instance.isWinter)
        {
            m_spriterenderer.sprite = winter_sprite;
        }
        else
        {
            m_spriterenderer.sprite = summer_sprite;
        }
    }
}
