using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D player_rigidbody;

    [SerializeField] protected float speed = 5;
    void Awake()
    {
        player_rigidbody = this.GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float x_movement = Input.GetAxisRaw("Horizontal");
        float y_movement = Input.GetAxisRaw("Vertical");

        player_rigidbody.velocity = new Vector2(x_movement * speed, y_movement * speed);
    }
}
