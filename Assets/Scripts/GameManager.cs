using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;

    public bool InGame;

    public GameObject Buttons;

    public static GameManager instance;

    public int score;

    private void Awake()
    {
        InGame = true;
        score = 0;

    }

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        if (MenuManager.instance.buttons)
        {
            Buttons.SetActive(true);
        }
        else if(!MenuManager.instance.buttons)
        {
            Buttons.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        if (InGame == false)
        {
            SceneManager.LoadScene("GameOver");
            UpdateOnScreenScore();
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        InGame = true;
    }

    public void UpdateOnScreenScore()
    {
        ScoreText.text = "Score: " + score.ToString();
    }
}
