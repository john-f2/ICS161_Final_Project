﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBScript : MonoBehaviour
{
    private bool isFixed = false;
    public bool isOpen = false;

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
                        DialougeTypeScript.instance.WriteText("Used Honey to fix lever!");
                    }
                    else
                    {
                        DialougeTypeScript.instance.WriteText("The lever is broken...");
                    }
                }
                else
                {
                    if (LevelManagerScript.instance.isWinter)
                    {
                        isOpen = true;
                        DialougeTypeScript.instance.WriteText("I pulled the lever. I think the gate should be open now.");
                    }
                    else
                    {
                        DialougeTypeScript.instance.WriteText("The honey is too liquid to pull the lever...");
                    }
                }
            }
        }
    }
}
