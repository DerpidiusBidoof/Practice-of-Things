using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditsMenu;

    public void switchToMainMenu()
    {
        //PlayButtonSound();

        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }

    public void switchToCreditsMenu()
    {
        //PlayButtonSound();

        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void QuitGame()
    {
        //PlayButtonSound();
        Application.Quit();
    }

    // void PlayButtonSound()
    //{
    //  SoundManager.Instance.Play("ButtonSelect");
    //}
}