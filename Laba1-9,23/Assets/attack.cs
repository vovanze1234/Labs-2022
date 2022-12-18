using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackpos;
    public float attackRange;
    public LayerMask whatisenemies;
    public int damage;
    void Update()
    { 
        if (timeBtwAttack <= 0)
        {
            
            if (Input.GetKey(KeyCode.Space))
            {
                Collider2D[] endamage = Physics2D.OverlapCircleAll(attackpos.position,attackRange,whatisenemies);
                for (int i = 0; i < endamage.Length; i++)
                {
                    endamage[i].GetComponent<vrag>().TakeDamage(damage);
                }
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackpos.position, attackRange);
    }

}
