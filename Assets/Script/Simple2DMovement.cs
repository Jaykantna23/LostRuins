using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple2DMovement : MonoBehaviour
{
    public float moveSpeed=5f;
    public Transform player;
    float move;
    Rigidbody2D rb;
    public Animator animator;
    bool m_FacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput=0f;
        move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(move));
        player.position += new Vector3(move, 0, 0);
        // float verticalInput=0f;
        //if (Input.GetKey(KeyCode.A))
        //{
        //    horizontalInput=-1f;
        //}
        //if(Input.GetKey(KeyCode.D))
        //{
        //    horizontalInput=1f;
        ////}
        //    Vector2 movement= new Vector2(horizontalInput*moveSpeed,rb.velocity.y);
        //rb.velocity=movement;
        if (move > 0 && !m_FacingRight)
        {
            // ... flip the player.
            //Debug.Log("Player flipped");
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (move < 0 && m_FacingRight)
        {
            // ... flip the player.
            //Debug.Log("Player flipped");
            Flip();
        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
