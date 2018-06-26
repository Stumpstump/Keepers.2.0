using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalWater : MonoBehaviour
{

    public GameObject Item;


    private void OnTriggerStay(Collider Player)
    {
       
        if (Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown("joystick button 3"))
        {
            SceneManager.LoadScene(2);
  
        }
 
    }
}




