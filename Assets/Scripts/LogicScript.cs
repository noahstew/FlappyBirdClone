using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public static int playerScore;
    public static bool onStart = true;
    public Text scoreText;
    public Text finalScoreText;
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public GameObject score;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        finalScoreText.text = "Score: " + playerScore.ToString();
    }

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameStartUI()
    {   
        startScreen.SetActive(true);
        gameOverScreen.SetActive(false);

    }

    public void gameOverUI()
    {
        playerScore = 0;
        gameOverScreen.SetActive(true);
    }
}
