using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SeasonChangeSpriteScript : MonoBehaviour
{
    [SerializeField] protected Sprite winter_sprite;
    [SerializeField] protected Sprite summer_sprite;
    [SerializeField] protected bool winterwall;
    private SpriteRenderer m_spriterenderer;
    private BoxCollider2D m_wall;

    void Awake()
    {
        m_spriterenderer = this.GetComponent<SpriteRenderer>();
        m_wall = this.GetComponent<BoxCollider2D>();
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
            if (m_wall)
            {
                if (winterwall)
                    m_wall.enabled = true;
                else
                    m_wall.enabled = false;
            }
            m_spriterenderer.sprite = winter_sprite;
        }
        else
        {
            if (m_wall)
            {
                if (winterwall)
                    m_wall.enabled = false;
                else
                    m_wall.enabled = true;
            }
            m_spriterenderer.sprite = summer_sprite;
        }
    }
}
