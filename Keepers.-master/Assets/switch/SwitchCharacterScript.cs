using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

   
    public GameObject avatar1, avatar2, cameraforav1, cameraforav2;
    public ParticleSystem particle1, particle2;

    int AdrianKiwiSwitch = 1;

    void Start() {

       
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
    }

 
            public void Update()

            {
        if (Input.GetKeyDown("joystick button 2"))



            switch (AdrianKiwiSwitch)  
        {

                    case 1:   
                        AdrianKiwiSwitch = 2;

                    avatar1.gameObject.SetActive(false);
                    cameraforav1.gameObject.SetActive(false);
                    avatar2.gameObject.SetActive(true);
                    cameraforav2.gameObject.SetActive(true);
                    avatar2.transform.position = avatar1.transform.position;
                        particle1.Play();



                    break;

                   
                    case 2:

                       
                        AdrianKiwiSwitch = 1;

                        
                        avatar1.gameObject.SetActive(true);
                    cameraforav1.gameObject.SetActive(true);
                    avatar2.gameObject.SetActive(false);
                    cameraforav2.gameObject.SetActive(false);
                    avatar1.transform.position = avatar2.transform.position;
                        particle2.Play();
                    break;

            }

            }
    } 
