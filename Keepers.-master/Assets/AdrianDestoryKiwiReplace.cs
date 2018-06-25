using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdrianDestoryKiwiReplace : MonoBehaviour
{

    public GameObject avatar1, avatar2;
    int whichAvatarIsOn = 1;
    void Start()
    {

    }


    public void Update()

    {
     

        if (Input.GetKeyDown("joystick button 2"))

            switch (whichAvatarIsOn)
            {
                case 1:


                    whichAvatarIsOn = 2;

                    GameObject.Instantiate(avatar2);
                    GameObject.Destroy(avatar1);

                    break;


                case 2:


                    whichAvatarIsOn = 1;

                    GameObject.Instantiate(avatar1);
                    GameObject.Destroy(avatar2);
                    break;

            }


    }
}