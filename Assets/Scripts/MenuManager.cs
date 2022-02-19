using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsMenuPanel;
    public GameObject CreditsPanel;

    public static MenuManager instance;

    void Awake()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);

        if (instance == null)
        {
            instance = this;
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
}
