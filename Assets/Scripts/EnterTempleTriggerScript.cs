using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTempleTriggerScript : MonoBehaviour
{
    [SerializeField] protected GameObject TempleInsideSpawn;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.gameObject.transform.position = TempleInsideSpawn.transform.position;
        }
    }
}
