using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;

    void Start()
    {
        ScoreText.text = "Score: " + GameManager.instance.score.ToString();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            if(GameManager.instance.score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", GameManager.instance.score);
                HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore");
            }
            else
            {
                HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore");
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", GameManager.instance.score);
            HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore");
        }
    }
}
