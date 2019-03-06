using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAScript : MonoBehaviour
{
    public bool isOpen = false;

    [SerializeField] protected Sprite frozen_lever;
    [SerializeField] protected Sprite open_lever;

    private SpriteRenderer m_spriterenderer;

    void Awake()
    {
        m_spriterenderer = this.GetComponentInChildren<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                if (LevelManagerScript.instance.isWinter)
                {
                    LevelManagerScript.instance.WriteText("I can't pull the lever when it's frozen...");
                }
                else
                {
                    isOpen = true;
                    m_spriterenderer.sprite = open_lever;
                    LevelManagerScript.instance.WriteText("I pulled the lever! I think a gate should be open now.");
                    this.GetComponentInChildren<SeasonChangeSpriteScript>().enabled = false;
                }
            }
        }
    }
}
