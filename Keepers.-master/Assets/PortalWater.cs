using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalWater : MonoBehaviour
{

    public GameObject Character;
    public GameObject Collider;
    


    void Update()
    {
        RaycastHit hit;
        float theDistance;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 20;

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            theDistance = hit.distance;
            print(theDistance + " " + hit.collider.gameObject.name);
        }

    }
}


