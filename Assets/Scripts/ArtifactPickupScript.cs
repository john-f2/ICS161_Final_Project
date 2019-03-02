using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactPickupScript : MonoBehaviour
{
    [SerializeField] protected GameObject SeasonChangeImage;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            LevelManagerScript.instance.WriteText("I wonder what that object is...");
        }
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                SeasonChangeImage.GetComponent<Image>().enabled = true;
                SeasonChangeImage.GetComponent<SeasonChangeButtonScript>().enabled = true;
                LevelManagerScript.instance.WriteText("Picked up the artifact!");
                Destroy(this.gameObject);
            }
        }
    }
}
