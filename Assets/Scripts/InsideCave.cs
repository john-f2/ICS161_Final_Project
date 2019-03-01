using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideCave : MonoBehaviour
{
    public GameObject player;
    public float[] boundary;

    // Start is called before the first frame update

    void Awake()
    {
        this.player = GameObject.Find("Player");
        this.boundary = new float[] {-4.5f, 3.5f, -3.0f, 3.5f};
    }
    void Start()
    {
        this.player.transform.position = new Vector2(0, -2);
    }

    // Update is called once per frame
    void Update()
    {
        this.CheckBoundaries();
        this.CheckExit();
    }

    void CheckBoundaries()
    {
        if (this.player.transform.position.x <= this.boundary[0])
        {
            this.player.transform.position = new Vector2(this.boundary[0], this.player.transform.position.y);
        }
        if (this.player.transform.position.x >= this.boundary[1])
        {
            this.player.transform.position = new Vector2(this.boundary[1], this.player.transform.position.y);
        }
        if (this.player.transform.position.y <= this.boundary[2])
        {
            this.player.transform.position = new Vector2(this.player.transform.position.x, this.boundary[2]);
        }
        if (this.player.transform.position.y >= this.boundary[3])
        {
            this.player.transform.position = new Vector2(this.player.transform.position.x, this.boundary[3]);
        }
    }

    void CheckExit()
    {

    }
}
