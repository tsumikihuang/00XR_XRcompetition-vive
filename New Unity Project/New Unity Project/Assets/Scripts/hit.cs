﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag=="activator")
        Debug.Log("hit! hit!");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
