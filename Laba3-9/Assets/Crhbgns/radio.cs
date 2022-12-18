using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : MonoBehaviour
{
    public int zvuk;
    private AudioSource AC;
    // Start is called before the first frame update
    void Start()
    {
        AC = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        zvuk += 1;
        if (zvuk % 2 == 1)
        { 
            AC.Pause();
        }
        else
        {
            AC.Play();
        }
    }
}
