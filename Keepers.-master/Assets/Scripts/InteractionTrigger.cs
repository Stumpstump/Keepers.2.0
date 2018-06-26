using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{

    public GameObject light;
    private bool on = false;


    // Use this for initialization
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("joystick button 3") && !on)
        {
            light.SetActive(true);
            on = true;
        }
        else if (Input.GetKeyDown("joystick button 3") && on)
        {
            light.SetActive(false);
            on = false;
        }
    }
}