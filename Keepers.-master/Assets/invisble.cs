﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisble : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
