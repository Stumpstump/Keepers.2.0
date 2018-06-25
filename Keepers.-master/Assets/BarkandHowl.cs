using System;
using Random = UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class BarkandHowl : MonoBehaviour

{
    private Animator anim;
    private AudioSource audio;
    public AudioClip[] clips;
    int number;
    public ParticleSystem particle1, particle2;
    public float cooldownTime = 3;
    private float nextFireTime = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown("joystick button 1") && !audio.isPlaying)
            {
                int randomClip = Random.Range(0, clips.Length);
                audio.clip = clips[randomClip];
                audio.Play();
                particle1.Play();
                nextFireTime = Time.time + cooldownTime;
            }

            if (Input.GetKeyDown("joystick button 5"))
            {
                anim.Play("Hawl");
                particle2.Play();
            }

        }


    }
}
