using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CS : MonoBehaviour {
    public string scenename;
    //public int sec=0;
    bool is_triger=false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (is_triger)
        {
            SteamVR_LoadLevel.Begin(scenename);
        }
	}


    void OnTriggerEnter(Collider col)
    {
		
        is_triger=true;
    }
}
