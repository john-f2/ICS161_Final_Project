using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverAScript : MonoBehaviour
{

    [SerializeField] protected Sprite frozen_lever;
    [SerializeField] protected Sprite open_lever;
    [SerializeField] protected AudioClip clickLever;

    private SpriteRenderer m_spriterenderer;

    public UnityEvent OnLeverAPull;

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
                    OnLeverAPull.Invoke();
                    m_spriterenderer.sprite = open_lever;
                    SFXManagerScript.instance.PlaySFX(clickLever);
                    SFXManagerScript.instance.PlayAchievement();
                    LevelManagerScript.instance.WriteText("I pulled the lever! I think a gate should be open now.");
                    this.GetComponentInChildren<SeasonChangeSpriteScript>().enabled = false;
                }
            }
        }
    }
}
