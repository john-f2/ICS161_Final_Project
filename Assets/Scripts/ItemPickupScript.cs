using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                if (this.name == "Honey")
                {
                    PlayerInventoryScript.instance.hasHoney = true;
                    LevelManagerScript.instance.WriteText("Honey picked up!");
                    LevelManagerScript.instance.summerObjectList.Remove(this.gameObject);
                }
                Destroy(this.gameObject);
            }
        }
    }

}
