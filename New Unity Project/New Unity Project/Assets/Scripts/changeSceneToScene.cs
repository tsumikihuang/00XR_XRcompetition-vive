using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneToScene : MonoBehaviour {
    public string scenename;
    public int sec=0;
    bool is_triger=false;
    public AudioSource AS_mov; //影片音軌

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (is_triger)
        {
            StartCoroutine(LoadScene());
        }
	}

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(sec);//括號內填入影片時間
        AS_mov.Play();

        SteamVR_LoadLevel.Begin(scenename);
    }

    void OnTriggerEnter(Collider col)
    {
        is_triger=true;
    }
}
