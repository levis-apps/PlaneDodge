﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane1 : MonoBehaviour
{
    public AudioSource source;
    public SpriteRenderer spriteRenderer;
    public Sprite Plane_1;
    public Sprite Plane_2;
    public Sprite Plane_3;
    public Sprite Plane_4;
    public int health = 1;
    public int mul = 1;
    void Start()
    {
        if (PlayerPrefs.HasKey("PlaneNumber"))
        {
            int tempPlane = PlayerPrefs.GetInt("PlaneNumber");
            switch (tempPlane)
            {
                case 1:
                    spriteRenderer.sprite = Plane_1;
                    PlaneMonemevt.speed = 30;
                    mul = 1;
                    break;
                case 2:
                    spriteRenderer.sprite = Plane_2;
                    PlaneMonemevt.speed = 60;
                    mul = 2;
                    break;
                case 3:
                    spriteRenderer.sprite = Plane_3;
                    PlaneMonemevt.speed = 100;
                    mul = 4;
                    health = 2;
                    break;
                case 4:
                    spriteRenderer.sprite = Plane_4;
                    PlaneMonemevt.speed = 110;
                    mul = 5;
                    health = 3;
                    break;
            }
        }
        else
        {
            spriteRenderer.sprite = Plane_1;
            PlaneMonemevt.speed = 70;
            mul = 1;
        }
    }
    void Update()
    {
        int tempScore = Score.scoreVal;
        if (health <= 0)
        {
            if (PlayerPrefs.HasKey("Score"))
            {
                PlayerPrefs.SetInt("Score", tempScore);
                if (PlayerPrefs.HasKey("Record"))
                {
                    if (tempScore > PlayerPrefs.GetInt("Record"))
                    {
                        PlayerPrefs.SetInt("Record", tempScore);
                        PlayerPrefs.SetInt("NewRecord", 1);
                    }
                    else {
                        PlayerPrefs.SetInt("NewRecord", 0);
                    }
                }
            }
            else
            {
                PlayerPrefs.SetInt("Record", tempScore);
            }
            PlayerPrefs.SetInt("Score", tempScore);
            if (PlayerPrefs.HasKey("Coin"))
            {
                PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + CoinScore.coinVal * mul);
            }
            else
            {
                PlayerPrefs.SetInt("Coin", CoinScore.coinVal);
            }
            CoinScore.coinVal = 0;
            Score.scoreVal = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
    public void makeSound()
    {
        source.Play();
    }
}
