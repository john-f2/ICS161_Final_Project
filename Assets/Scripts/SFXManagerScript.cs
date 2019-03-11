using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManagerScript : MonoBehaviour
{
    public static SFXManagerScript instance { get; private set; }

    public AudioSource m_SFXPlayer;

    [SerializeField] protected AudioClip achievementSound;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this.gameObject);
    }

    public void PlayAchievement()
    {
        PlaySFX(achievementSound);
    }

    public void PlaySFX(AudioClip variable)
    {
        m_SFXPlayer.PlayOneShot(variable, Random.Range(0.7f, 1.0f));
    }
}
