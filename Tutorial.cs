using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {
    void Start () {
        if (!PlayerPrefs.HasKey("PlayedBefore")) {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("PlayedBefore", 1);
        } else {
            gameObject.SetActive(false);
        }
    }
}