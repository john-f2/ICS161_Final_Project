using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanelScript : MonoBehaviour
{
    private GameObject honeyChild;

    void Awake()
    {
        honeyChild = transform.Find("HoneyInInventory").gameObject;
    }
    void OnEnable()
    {
        if (PlayerInventoryScript.instance.hasHoney)
        {
            honeyChild.SetActive(true);
        }
        else if (!PlayerInventoryScript.instance.hasHoney)
        {
            honeyChild.SetActive(false);
        }
    }
   
}
