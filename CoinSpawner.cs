using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPatterns;
    public float startTBS = 20;
    private float timeBS;
    
    void Update()
    {
        if(timeBS <= 0){
            int r = Random.Range(0, coinPatterns.Length);
            float s = Random.Range(startTBS, 35);
            Instantiate(coinPatterns[r], transform.position, Quaternion.identity);
            timeBS = s;
        }
        else{
            timeBS -= Time.deltaTime;
        }
    }
}