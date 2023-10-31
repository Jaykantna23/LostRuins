using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    private Rigidbody2D rb;
    public static int velocity = 1;
    // private bool up = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(rb.transform.position.y >= 3.56){
            velocity = -1;
        }
        else if(rb.transform.position.y <= -1.54){
            velocity = 1;
        }
        rb.velocity = new Vector2(0, 2*velocity);
    }
    // private void OnCollisionEnter2D(Collision2D other) {
    //     if(other.gameObject.tag == "Player"){
    //         other.gameObject.transform.position.x = rb.transform.position.x;
    //     }
    // }
}
