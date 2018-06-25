using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

        public void Update ()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene(1);
        }

    }
}
