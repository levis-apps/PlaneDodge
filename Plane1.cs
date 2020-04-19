using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane1 : MonoBehaviour
{
    /*public float speed = 80f;
    public float maxY = 2.5f;
    public float minY = -2.5f;
    private Vector2 targetPos;
    private float ScreenWidth;
    public Animator animator;
    private Rigidbody2D rb;
    void Start()
    {
        ScreenWidth = Screen.width;
        rb = GetComponent<Rigidbody2D>();
        targetPos = new Vector2(-6.0f, 0.0f);
    }*/
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
/*
        float tempY = rb.velocity.y;
        animator.SetFloat("SpeedD", Mathf.Abs(tempY));
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(transform.position == targetPos){
            i = 0;
        }

        if(i == 1){
            move right
            if(transform.position.y < maxY){
                targetPos = new Vector2(transform.position.x, transform.position.y);
            }
        }
        if(i == 2){
            move left
            if(transform.position.y > minY){
                targetPos = new Vector2(transform.position.x, transform.position.y);
            }
        }
    }*/
