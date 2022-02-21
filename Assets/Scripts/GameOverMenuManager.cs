using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        GameManager.instance.InGame = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
