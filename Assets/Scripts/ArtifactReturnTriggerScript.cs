﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactReturnTriggerScript : MonoBehaviour
{
    [SerializeField] protected GameObject SeasonChangeImage;
    [SerializeField] protected GameObject ArtifactWithGoddess;

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                SeasonChangeImage.GetComponent<SeasonChangeButtonScript>().enabled = false;
                LevelManagerScript.instance.hasArtifact = false;
                ArtifactWithGoddess.SetActive(true);
                SFXManagerScript.instance.PlayAchievement();
                LevelManagerScript.instance.EndGame();
            }
        }
    } 
}