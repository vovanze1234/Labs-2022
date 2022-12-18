using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour
{
    public int health;
    public float speed;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (health <= 0) { Destroy(gameObject); }
        {

        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage TAKEN !");
    }
}
