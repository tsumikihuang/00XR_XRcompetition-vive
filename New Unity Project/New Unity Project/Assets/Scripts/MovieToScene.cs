using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieToScene : MonoBehaviour {
    public string nextscene;
    public VideoPlayer movTexture;
    public int t_second;
    // Use this for initialization
    void Start () {
        //movTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(LoadScene());
    }
    /*
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(t_second);//括號內填入影片時間
        SteamVR_LoadLevel.Begin(nextscene);
    }
    */
}
