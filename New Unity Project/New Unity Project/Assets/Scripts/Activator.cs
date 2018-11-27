using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {
	
	public static int score = 0;
	GameObject _note;
    //public KeyCode key;
    bool active = false;
    GameObject note;
    private stage myA;
    private noteStruck for_Note;
    /*void Start () {
	//private bool struck_active = for_Note.false;
    //private int score= GameData.score;
	}*/

    // Update is called once per frame
    void Awake()
    {
        //Get the JavaScript component  
        myA = this.GetComponent<stage>();
        for_Note = this.GetComponent<noteStruck>();
		
    }
    private void OnTriggerEnter(Collider col)
    {
		if (col.gameObject.tag == "Note")
            _note = col.gameObject;
		
		switch(this.name){
			case "Activator_r":
				Debug.Log("is red!");
				gameObject.GetComponent<Renderer>().material.color = Color.red;
				break;
			case "Activator_b":
				Debug.Log("is blue!");
				gameObject.GetComponent<Renderer>().material.color = Color.blue;
				break;
			case "Activator_g":
				Debug.Log("is green!");
				gameObject.GetComponent<Renderer>().material.color = Color.green;
				break;
			default:
				Debug.Log("noooooooooooooooo!");
				break;
		}
		
		if(col.gameObject.tag == "noteStruck"){
			if (col.gameObject.tag == "Player")
			{
				active = true;
				note = col.gameObject;
			}
			if ((for_Note.GetComponent<noteStruck>().struck_active == true) && active)
			{
				myA.GetComponent<stage>().score++;
				System.Console.WriteLine(myA.GetComponent<stage>().score);
				Debug.Log(myA.GetComponent<stage>().score);
			}
		}
    }
    private void OnTriggerExit(Collider col)
    {
		gameObject.GetComponent<Renderer>().material.color = Color.black;
        if (col.gameObject.tag == "Player"){
            active = false;
		}
		Destroy(_note);
		
    }
}
