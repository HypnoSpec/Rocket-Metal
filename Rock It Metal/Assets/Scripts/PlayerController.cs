using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private float speed = 2;
    
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        } else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2;
        }
    }
}
