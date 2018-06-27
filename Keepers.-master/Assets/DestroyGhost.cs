using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGhost : MonoBehaviour {

    public GameObject avatar1;

    void OnCollisionEnter(Collision Ghost)
    {
        if (Ghost.gameObject.name == "Spirit")
        {
            avatar1.gameObject.SetActive(false);
        }
    }
}
