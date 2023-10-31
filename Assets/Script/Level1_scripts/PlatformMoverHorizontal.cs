using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoverHorizontal : MonoBehaviour
{
    private Rigidbody2D rb;
    public static int velocity = 1;
    public GameObject player;
    private bool isInContact = false;
    private static float PlayerInitialX;
    private static float PlatformInitialX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(rb.transform.position.x >= 22){
            velocity = -1;
        }
        else if(rb.transform.position.x <= 17.26){
            velocity = 1;
        }
        rb.velocity = new Vector2(2*velocity,0);
        if(isInContact){
            player.transform.position = new Vector3(PlayerInitialX -PlatformInitialX+ rb.transform.position.x, player.transform.position.y, player.transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            isInContact = true;
            PlayerInitialX = player.transform.position.x;
            PlatformInitialX = rb.transform.position.x;
        }
    }
    private void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            isInContact = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            isInContact = false;
        }
    }
}
