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

        if(MenuManager.instance.level == 1)
        {
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

        if (MenuManager.instance.level == 2)
        {
            if (PlayerPrefs.HasKey("HighScore2"))
            {
                if (GameManager.instance.score > PlayerPrefs.GetInt("HighScore2"))
                {
                    PlayerPrefs.SetInt("HighScore2", GameManager.instance.score);
                    HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore2");
                }
                else
                {
                    HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore2");
                }
            }
            else
            {
                PlayerPrefs.SetInt("HighScore2", GameManager.instance.score);
                HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore2");
            }
        }

        if (MenuManager.instance.level == 3)
        {
            if (PlayerPrefs.HasKey("HighScore3"))
            {
                if (GameManager.instance.score > PlayerPrefs.GetInt("HighScore3"))
                {
                    PlayerPrefs.SetInt("HighScore3", GameManager.instance.score);
                    HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore3");
                }
                else
                {
                    HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore3");
                }
            }
            else
            {
                PlayerPrefs.SetInt("HighScore3", GameManager.instance.score);
                HighScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore3");
            }
        }

    }
}
