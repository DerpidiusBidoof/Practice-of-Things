using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance;

    private int p1Score;
    private int p2Score;
    public int winScore;
    public string winMessage;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI winMessageText;


    private void Awake()
    {
        Instance = this;
    }

    private void CheckWin()
    {
        if (p1Score >= winScore)
        {
            winMessageText.text = "PLAYER 1 ACHIEVES " + winMessage;
            Restart.Instance.GameOver();
        }
        else if (p2Score >= winScore)
        {
            winMessageText.text = "PLAYER 2 ACHIEVES " + winMessage;
            Restart.Instance.GameOver();
        }
        else
        {
            BallSpawner.Instance.SpawnBall();
        }
    }
    public void GivePointToP1()
    {
        p1Score++; //++ means add 1
        p1ScoreText.SetText(p1Score.ToString());
        CheckWin();
    }

    public void GivePointToP2()
    {
        p2Score++;
        p2ScoreText.SetText(p2Score.ToString());
        CheckWin();
    }
}
