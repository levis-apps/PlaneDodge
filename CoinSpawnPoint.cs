using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnPoint : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}