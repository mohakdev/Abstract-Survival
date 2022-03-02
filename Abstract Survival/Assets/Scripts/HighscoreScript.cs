using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighscoreScript : MonoBehaviour
{
    Text Label;
    private void Awake()
    {
        Label = GetComponent<Text>();
    }
    private void Update()
    {
        int Highscore = PlayerPrefs.GetInt("HS", 0);
        Label.text = "HIGHSCORE : " + Highscore.ToString();
    }
}
