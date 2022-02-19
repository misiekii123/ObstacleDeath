using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
