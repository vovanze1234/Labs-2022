using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lovushka : MonoBehaviour
{
    public int speed ;
    Rigidbody2D rb;
    public int damage;
    public bool lovi;
    public DateTime mydate;
    public Transform attackpos;
    public float attackRange;
    public LayerMask whatisenemies;
    public bool Hit = true;
    public float time = 3f;
    public Transform player;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            lovi = true;
        }


    }
    public void Update()
    {
        if (lovi == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);
        }
        Collider2D[] endamage = Physics2D.OverlapCircleAll(attackpos.position, attackRange, whatisenemies);
        for (int i = 0; i < endamage.Length; i++)
        {
            endamage[i].GetComponent<player>().TakeDamage(damage);
            Hit = false;
        }
        if (Hit == false)
        {
            Destroy(gameObject);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackpos.position, attackRange);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

        
 
}
