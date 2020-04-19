using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{
    public AudioSource source;
    public void PlayGame()
    {
        source.Play();
        SceneManager.LoadScene("Game");
    }
    public void Hangar()
    {
        source.Play();
        SceneManager.LoadScene("Hangar");
    }
}