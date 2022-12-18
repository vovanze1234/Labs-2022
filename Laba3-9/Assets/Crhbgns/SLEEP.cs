using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLEEP : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource Sleep;
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
        {
            Sleep.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Sleep.Stop();
    }
    private void Start()
    {
        Sleep = GetComponent<AudioSource>();
    }

}
