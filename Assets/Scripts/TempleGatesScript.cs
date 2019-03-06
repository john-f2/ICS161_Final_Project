using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TempleGatesScript : MonoBehaviour
{
    [SerializeField] protected GameObject blueBarriers;
    [SerializeField] protected GameObject orangeBarriers;
    [SerializeField] protected GameObject ALever;
    [SerializeField] protected GameObject BLever;

    void Start()
    {
        ALever.GetComponent<LeverAScript>().OnLeverAPull.AddListener(OnLeverAPullListener);
        BLever.GetComponent<LeverBScript>().OnLeverBPull.AddListener(OnLeverBPullListener);
    }

    void OnLeverAPullListener()
    {
        orangeBarriers.SetActive(false);
    }

    void OnLeverBPullListener()
    {
        blueBarriers.SetActive(false);
    }
}
