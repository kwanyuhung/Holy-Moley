using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    public AudioSource footstep;
    // Start is called before the first frame update
    void Start()
    {
        footstep.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
