using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public static float currentSpeed = 3f;
    public static float mSpeed = 5f;
    public float maxSpeed = 15f;
    float speed = 1f;
    void Start () {
        if (currentSpeed < 15f) {
            speed = Random.Range (currentSpeed, mSpeed);
        } else {
            speed = 17f;
        }
    }
    void Update () {
        transform.Translate (Vector3.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D (Collider2D col) {
        if (col.CompareTag ("Plane")) {
            col.GetComponent<Plane1> ().health -= 1;
            Destroy (gameObject);
        }
    }
    void OnBecameInvisible () {
        Destroy (gameObject);
    }
}