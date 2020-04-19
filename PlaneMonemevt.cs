using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMonemevt : MonoBehaviour {
    public static float speed = 60;
    public GameObject character;
    private float ScreenWidth;
    public float maxY = 2.5f;
    public float minY = -2.5f;
    public Vector2 target;
    public AudioSource source;
    void Start () {
        ScreenWidth = Screen.width;
        target = new Vector2 (-6.0f, 0.0f);
    }
    void Update () {
        character.transform.position = Vector2.MoveTowards (character.transform.position, target, speed * Time.deltaTime);
        if (Input.touchCount == 1) {
            if (Input.GetTouch (0).phase == TouchPhase.Began) {
                if (Input.GetTouch (0).position.x > ScreenWidth / 2) {
                    //move right
                    if (character.transform.position.y < maxY) {
                        target = new Vector2 (-6.0f, character.transform.position.y + 2.5f);
                        source.Play ();
                    }
                } else if (Input.GetTouch (0).position.x < ScreenWidth / 2) {
                    //move left
                    if (character.transform.position.y > minY) {
                        target = new Vector2 (-6.0f, character.transform.position.y - 2.5f);
                        source.Play ();
                    }
                }
            }
        }
    }
}