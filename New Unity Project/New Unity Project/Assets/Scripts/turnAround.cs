using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnAround : MonoBehaviour {
    public float _RotationSpeed = 1;
    //public GameObject explosionPrefab;

    // Use this for initialization
    void Start () {
        //Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.down * _RotationSpeed, Space.World);
    }
}
