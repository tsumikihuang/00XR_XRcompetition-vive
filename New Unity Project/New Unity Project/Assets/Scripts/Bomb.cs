using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    bool is_triger = false;
    public GameObject explosionPrefab;
    //public GameObject suiga;
    void Update()
    {
        if (is_triger)
        {
            SteamVR_LoadLevel.Begin("movie_1");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        is_triger = true;
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        //suiga.SetActive(false);     //將西瓜隱藏
        //SteamVR_LoadLevel.Begin("01");
    }
}