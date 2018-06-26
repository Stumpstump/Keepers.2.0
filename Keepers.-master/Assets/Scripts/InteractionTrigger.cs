using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{

    public GameObject light;
    public bool on = false;


    // Use this for initialization
    private void OnTriggerStay(Collider Player)
    {
        //joystick button 3 or KeyCode.E
        if (Input.GetKeyDown(KeyCode.M) && !on)
        {
            light.SetActive(true);
            on = true;
        }
        else if (Input.GetKeyDown(KeyCode.M) && on)
        {
            light.SetActive(false);
            on = false;
        }
    }
}