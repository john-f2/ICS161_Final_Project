using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyPickupScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("entered");
                PlayerInventoryScript.instance.hasHoney = true;
                DialougeTypeScript.instance.WriteText("Honey picked up!");
                Destroy(this.gameObject);
            }
        }
    }
}
