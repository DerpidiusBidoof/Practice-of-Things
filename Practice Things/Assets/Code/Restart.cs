using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public static Restart Instance;
    private void Awake()
    {
        Instance = this;
    }

    public GameObject restart;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        restart.SetActive(false);
        Debug.Log("Game reset.");
    }

    public void GameOver()
    {
        restart.SetActive(true);
    }
}
