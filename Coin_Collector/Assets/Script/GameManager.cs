using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    public GameObject ScorePlayer1;
    public GameObject ScorePlayer2;

    public GameObject player1win;
    public GameObject player2win;



    // Update is called once per frame
    void Update()
    {
        if (ScorePlayer1 > ScorePlayer2) 
        {
   
            player1.SetActive(false);
            player1win.SetActive(true);
        }

        if(ScorePlayer2 > ScorePlayer1)
        {
            player2.SetActive(false);
            player2win.SetActive(true);
        }

    }
}
