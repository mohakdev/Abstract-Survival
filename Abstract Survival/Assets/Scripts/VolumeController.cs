using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VolumeController : MonoBehaviour
{
    public AudioSource AudioPlayer;
    private void Start()
    {
        AudioPlayer = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
    }
    public void SetVolume(float Uservolume)
    {
        AudioPlayer.volume = Uservolume;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
