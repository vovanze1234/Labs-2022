using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator anim;
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    private bool isGrounded = false;
    public int moveinput;
    public int attack;
    public int health;
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    private void Update()
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
        if ((Input.GetKey(KeyCode.W)) && (isGrounded))
        {
            rb.AddForce((Vector2)(transform.up * jumpForce), ForceMode2D.Impulse);
        }
        if (moveinput == 1)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        if (timeBtwAttack <= 0)
        {

            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetTrigger("Attack");
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        CheckGround();
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isGrounded = collider.Length > 1;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage TAKEN !!!!!!!!!!!!!!");
    }
}
