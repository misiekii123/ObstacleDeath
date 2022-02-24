using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsMenuPanel;
    public GameObject CreditsPanel;

    public Text TextControlsButton;

    public static MenuManager instance;

    public bool buttons;


    void Awake()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);

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
            else if(PlayerPrefs.GetInt("buttons") == 0)
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

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenSettings()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }

    public void CloseSettings()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void OpenCredits()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
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
}
