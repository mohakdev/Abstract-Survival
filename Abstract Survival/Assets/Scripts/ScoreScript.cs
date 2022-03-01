using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float Score;
    public int IncrementPerFrame;
    Text ScoreLabel;
    private void Awake()
    {
        ScoreLabel = GetComponent<Text>();
    }
    private void Update()
    {
        Score += IncrementPerFrame * Time.deltaTime;
        int DisplayScore = ((int)Score);
        ScoreLabel.text = "SCORE : " + DisplayScore;
    }
    public void SetHighScore()
    {
        int Highscore = PlayerPrefs.GetInt("HS", 0);
        if (Highscore < Score)
        {
            PlayerPrefs.SetInt("HS", ((int)Score));
        }
    }
}