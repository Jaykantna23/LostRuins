using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetector : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float speed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalSpeed = 0;
        if(Input.GetKey("left"))
        {
            horizontalSpeed = -1;
        }
        if(Input.GetKey("right"))
        {
            horizontalSpeed = 1;
        }
        Vector2 movement = new Vector2(horizontalSpeed * speed, rb.velocity.y);
        rb.velocity = movement;
    }
}
