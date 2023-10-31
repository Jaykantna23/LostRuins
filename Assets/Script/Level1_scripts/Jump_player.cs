using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_player : MonoBehaviour
{
    Rigidbody2D rb;
    bool OnGround;
    public float jumpSpeed=10f;
    // Start is called before the first frame update
    void Start()
    {
       OnGround=true;
       rb=GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space)&& OnGround)
       {
        rb.velocity=new Vector2(rb.velocity.x,jumpSpeed);
       } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            OnGround = false;
        }
    }
}