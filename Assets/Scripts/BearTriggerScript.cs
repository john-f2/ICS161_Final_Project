using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTriggerScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            DialougeTypeScript.instance.WriteText("The bear is blocking the cave...but I shouldn't wake him up.");
        }
    }

}
