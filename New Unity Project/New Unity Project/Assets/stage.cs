using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage : MonoBehaviour {
    public int score = 0;
    //bool stage_active = false;
    //GameObject _note;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (!stage_active)
        {
            Destroy(_note);
        }*/
    }
    private void OnTriggerEnter(Collider col)
    {
        /*stage_active = true;
        if (col.gameObject.tag == "Note")
            _note = col.gameObject;*/
    }
    private void OnTriggerExit(Collider col)
    {
        //stage_active = false;
    }
}
