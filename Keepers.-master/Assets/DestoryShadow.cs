using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryShadow : MonoBehaviour {

    public GameObject TheShadow;

	// Use this for initialization
	void Start () {
		
	}
	
	
	void OnTriggerStay(Collider Shadow)
    {

        Destroy(Shadow.gameObject);

		
	}
}
