using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    public int jumpForce;
    public bool grounded;
    public StateManager manager;
    public SoundManager sound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            if (grounded)
            {
                Jump();
            }
        }
    }
    void FixedUpdate()
    {
        if (manager.state == "Playing")
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    public void ResetGravity(int gravity)
    {
        rb.gravityScale = gravity;
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        sound.PlayJump();
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
            grounded = true;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
            grounded = false;
    }
}
