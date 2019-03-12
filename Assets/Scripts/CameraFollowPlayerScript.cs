using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayerScript : MonoBehaviour
{
    [SerializeField] protected GameObject player;

    [SerializeField] protected int min_bound_x;
    [SerializeField] protected int max_bound_x;
    [SerializeField] protected int min_bound_y;
    [SerializeField] protected int max_bound_y;

    // Update is called once per frame
    void Update()
    {
        Vector3 player_position = player.transform.position;
        this.transform.position = new Vector3(

            Mathf.Clamp(player_position.x, min_bound_x, max_bound_x),
            Mathf.Clamp(player_position.y, min_bound_y, max_bound_y), 
            -10);
    }
}
