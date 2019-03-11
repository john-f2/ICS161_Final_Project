using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverBScript : MonoBehaviour
{
    private bool isFixed = false;

    [SerializeField] protected Sprite broken_lever;
    [SerializeField] protected Sprite fixed_lever;
    [SerializeField] protected Sprite open_lever;
    [SerializeField] protected AudioClip clickLever;

    private SpriteRenderer m_spriterenderer;

    public UnityEvent OnLeverBPull;

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
                if(!isFixed)
                {
                    if (PlayerInventoryScript.instance.hasHoney)
                    {
                        isFixed = true;
                        PlayerInventoryScript.instance.hasHoney = false;
                        m_spriterenderer.sprite = fixed_lever;
                        LevelManagerScript.instance.WriteText("Used Honey to fix lever!");
                    }
                    else
                    {
                        LevelManagerScript.instance.WriteText("The lever is broken...");
                    }
                }
                else
                {
                    if (LevelManagerScript.instance.isWinter)
                    {
                        OnLeverBPull.Invoke();
                        m_spriterenderer.sprite = open_lever;
                        SFXManagerScript.instance.PlaySFX(clickLever);
                        SFXManagerScript.instance.PlayAchievement();
                        LevelManagerScript.instance.WriteText("I pulled the lever. I think a gate should be open now.");
                    }
                    else
                    {
                        LevelManagerScript.instance.WriteText("The honey is too liquid to pull the lever...");
                    }
                }
            }
        }
    }
}
