using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteStruck: MonoBehaviour {
    public bool struck_active = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "activator")
        {
            struck_active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        struck_active = false;
    }
}
