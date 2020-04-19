using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    public float startTBS;
    private float timeBS;
    public float dT;
    public float minT = 0.9f; 
    void Update()
    {
        if(timeBS <= 0){
            int r = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[r], transform.position, Quaternion.identity);
            Score.scoreVal += 10;
            Rocket.mSpeed += 0.4f;
            Rocket.currentSpeed += 0.4f;
            timeBS = startTBS;
            if(startTBS > minT){
                startTBS -= dT;
            }
        }
        else{
            timeBS -= Time.deltaTime;
        }
    }
}