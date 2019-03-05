using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveExit : MonoBehaviour
{
    public GameObject caveEntranceSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject player = GameObject.Find("Player");
            player.transform.position = caveEntranceSpawnPoint.transform.position;
            //collision.gameObject.transform.position = new Vector2(caveEntranceSpawnPoint.transform.position.x, caveEntranceSpawnPoint.transform.position.y - 2);
        }
    }
}
