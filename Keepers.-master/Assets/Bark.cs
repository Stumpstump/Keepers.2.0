using System;
using Random = UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class Bark : MonoBehaviour

{
    public AudioClip[] clips;
    public new AudioSource audio;
    int number;
    public ParticleSystem particle;
    public float cooldownTime = 3;
    private float nextFireTime = 0;

    void Start()
    {

    }

    private void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown("joystick button 1") && !audio.isPlaying)
            {
                int randomClip = Random.Range (0, clips.Length);
                audio.clip = clips[randomClip];
                audio.Play();
                particle.Play();
                nextFireTime = Time.time + cooldownTime;
            }
        }


    }
}
