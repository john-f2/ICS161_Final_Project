using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayerScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update

    void Awake()
    {
        this.player = GameObject.Find("Player");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 player_position = player.transform.position;
        this.transform.position = new Vector3(player_position.x, player_position.y, -10);
    }
}
