using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiwiJump : MonoBehaviour {
    public ParticleSystem particle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("joystick button 0"))
            particle.Play();

    }
}
