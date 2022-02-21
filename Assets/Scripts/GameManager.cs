using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;

    public bool InGame;

    public static GameManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void FixedUpdate()
    {
        if (InGame == false)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        InGame = true;
    }
}
