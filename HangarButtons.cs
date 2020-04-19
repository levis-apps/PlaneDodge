using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HangarButtons : MonoBehaviour
{
    public TextMeshProUGUI coins;
    public AudioSource source;
    public int Plane2_purchased = 0;
    public int Plane3_purchased = 0;
    public int Plane4_purchased = 0;
    
    void Update()
    {
        if(PlayerPrefs.HasKey("Coin")){
        coins.text = PlayerPrefs.GetInt("Coin").ToString();
        } else {
            coins.text = "0";
        }
    }
    public void BackButton()
    {
        source.Play();
        SceneManager.LoadScene("StartMenu");
    }

    public void Plane1Button()
    {
        source.Play();
        PlayerPrefs.SetInt("PlaneNumber", 1);
    }

    public void Plane2Button()
    {
        source.Play();
        if(PlayerPrefs.HasKey("P2P")){
            Plane2_purchased = PlayerPrefs.GetInt("P2P");
        }
        if(Plane2_purchased == 1){
            PlayerPrefs.SetInt("PlaneNumber", 2);
        }
        else{
            if(PlayerPrefs.HasKey("Coin")){
                int tempCoin = PlayerPrefs.GetInt("Coin");
                if(tempCoin > 500){
                    tempCoin -= 500;
                    PlayerPrefs.SetInt("Coin", tempCoin);
                    PlayerPrefs.SetInt("PlaneNumber", 2);
                    PlayerPrefs.SetInt("P2P", 1);
                } else {
                    SceneManager.LoadScene("GetCoin");
                }
            } else { 
                SceneManager.LoadScene("GetCoin");
            }
        }
    }

    public void Plane3Button()
    {
        source.Play();
        if(PlayerPrefs.HasKey("P3P")){
            Plane3_purchased = PlayerPrefs.GetInt("P3P");
        }
        if(Plane3_purchased == 1){
            PlayerPrefs.SetInt("PlaneNumber", 3);
        }
        else{
            if(PlayerPrefs.HasKey("Coin")){
                int tempCoin = PlayerPrefs.GetInt("Coin");
                if(tempCoin > 1000){
                    tempCoin -= 1000;
                    PlayerPrefs.SetInt("Coin", tempCoin);
                    PlayerPrefs.SetInt("PlaneNumber", 3);
                    PlayerPrefs.SetInt("P3P", 1);
                } else {
                    SceneManager.LoadScene("GetCoin");
                }
            } else { 
                SceneManager.LoadScene("GetCoin");
            }
        }
    }

    public void Plane4Button()
    {
        source.Play();
        if(PlayerPrefs.HasKey("P4P")){
            Plane4_purchased = PlayerPrefs.GetInt("P4P");
        }
        if(Plane4_purchased == 1){
            PlayerPrefs.SetInt("PlaneNumber", 4);
        }
        else{
            if(PlayerPrefs.HasKey("Coin")){
                int tempCoin = PlayerPrefs.GetInt("Coin");
                if(tempCoin > 2000){
                    tempCoin -= 2000;
                    PlayerPrefs.SetInt("Coin", tempCoin);
                    PlayerPrefs.SetInt("PlaneNumber", 4);
                    PlayerPrefs.SetInt("P4P", 1);
                } else {
                    SceneManager.LoadScene("GetCoin");
                }
            } else { 
                SceneManager.LoadScene("GetCoin");
            }
        }
    }

    public void BadgesButton(){
        SceneManager.LoadScene("Badges");
    }

    public void CoinButton()
    {
        source.Play();
        SceneManager.LoadScene("GetCoin");
    }
}