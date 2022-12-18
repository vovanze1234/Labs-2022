using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour 
{
    private AudioSource Sig;

    // Start is called before the first frame update
    void Start()
    {
        Sig = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void signal()
    {
        Sig.Play();
    }
}
