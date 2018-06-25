using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowlParticle : MonoBehaviour {

    private ParticleSystem ParticleHowl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 3"))
        {
            ParticleHowl.Play();
        }

    }

}
