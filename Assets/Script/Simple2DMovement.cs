using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple2DMovement : MonoBehaviour
{
    public float moveSpeed=5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput=0f;
        // float verticalInput=0f;
        if(Input.GetKey(KeyCode.A))
        {
            horizontalInput=-1f;
        }
        if(Input.GetKey(KeyCode.D))
        {
            horizontalInput=1f;
        }
        Vector2 movement= new Vector2(horizontalInput*moveSpeed,rb.velocity.y);
        rb.velocity=movement;
    }
}
