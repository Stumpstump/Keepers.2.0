using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howl : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem particle;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("joystick button 3"))
        {
            anim.Play("Hawl");
            particle.Play();
        }

    }
}
