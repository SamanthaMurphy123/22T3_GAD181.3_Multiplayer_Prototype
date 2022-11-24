using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreControl : MonoBehaviour
{
    [SerializeField]
    private Text scoreCounterPlayerOne, scoreCounterPlayerTwo;

    private int playerOneScore, playerTwoScore;

    [SerializeField] GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;

        scoreCounterPlayerOne.text = "P1 Score: " + playerOneScore;
        scoreCounterPlayerTwo.text = "P2 Score: " + playerTwoScore;

        Player.PlayerCollectsCoin += UpdateScore;
    }

    private void UpdateScore(string playerName)
    {
        if (playerName == "PlayerOne")
        {
            playerOneScore += 1;
            scoreCounterPlayerOne.text = "P1 Score: " + playerOneScore;
        }
        else if (playerName == "PlayerTwo")
        {
            playerTwoScore += 1;
            scoreCounterPlayerTwo.text = "P2 Score: " + playerTwoScore;
        }
    }
    private void WinScreen()
    {
        if (playerOneScore > playerTwoScore && !coin)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (playerTwoScore > playerOneScore && !coin)
        {
            SceneManager.LoadScene("WinScreen2");
        }
    }

    private void OnDestroy()
    {
        Player.PlayerCollectsCoin -= UpdateScore;
    }
}
