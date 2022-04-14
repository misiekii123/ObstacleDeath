using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("Menu panels")]
    public GameObject MainMenuPanel;
    public GameObject SettingsMenuPanel;
    public GameObject CreditsPanel;
    public GameObject LevelsPanel;

    [Header("Controls buttons text")]
    public Text TextControlsButton;

    [Header("Levels")]
    public int level;

    [Header("Other")]
    public bool buttons;

    public static MenuManager instance;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        if (PlayerPrefs.HasKey("buttons"))
        {
            if (PlayerPrefs.GetInt("buttons") == 1)
            {
                buttons = true;
                TextControlsButton.text = "Controls:\nbuttons";
            }
            else if (PlayerPrefs.GetInt("buttons") == 0)
            {
                buttons = false;
                TextControlsButton.text = "Controls:\ntouch";
            }
        }
        else
        {
            buttons = false;
            TextControlsButton.text = "Controls:\ntouch";
        }
    }

    private void Start()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        LevelsPanel.SetActive(false);
    }

    public void StartGame()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        LevelsPanel.SetActive(true);
    }

    public void OpenSettings()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        LevelsPanel.SetActive(false);
    }

    public void CloseSettings()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        LevelsPanel.SetActive(false);
    }

    public void OpenCredits()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        LevelsPanel.SetActive(false);
    }

    public void CloseCredits()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        LevelsPanel.SetActive(false);  
    }

    public void ChangeControls()
    {
        buttons = !buttons;

        if(buttons == true)
        {
            TextControlsButton.text = "Controls:\nbuttons";
            PlayerPrefs.SetInt("buttons", 1);
        }
        else if(buttons == false)
        {
            TextControlsButton.text = "Controls:\ntouch";
            PlayerPrefs.SetInt("buttons", 0);
        }
    }

    public void level1()
    {
        level = 1;
        SceneManager.LoadScene("Game");
    }

    public void level2()
    {
        level = 2;
        SceneManager.LoadScene("Game");
    }

    public void level3()
    {
        level = 3;
        SceneManager.LoadScene("Game");
    }
}
