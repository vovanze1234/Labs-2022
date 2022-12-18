using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class but : MonoBehaviour
{
    public void Turn()
    {
        GetComponent<PostProcessVolume>().enabled = !GetComponent<PostProcessVolume>().enabled;
    }
}
