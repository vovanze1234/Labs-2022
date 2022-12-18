using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Animator anim;
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    public int moveinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(x: speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(x: -speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            moveinput = 1;
        }
        else
        {
            moveinput = 0;
        }
        if ((Input.GetKey(KeyCode.W)) )
        {
            rb.AddForce((Vector2)(transform.up * jumpForce), ForceMode2D.Impulse);
        }
    }
}
