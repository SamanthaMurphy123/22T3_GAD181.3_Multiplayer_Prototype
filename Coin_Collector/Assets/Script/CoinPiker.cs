using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinPiker : MonoBehaviour
{
    // The number of coins collected by each player
    public int Coin1 = 0;
    public int Coin2 = 0;

    // The TextMeshProUGUI component used to display the number of coins collected by each player
    public TextMeshProUGUI textCoin;

    // The AudioClip to play when a player collects a coin
    public AudioClip coinSound;

    // The GameObject for player 1
    public GameObject player1;

    // The GameObject for player 2
    public GameObject player2;

    void Update()
    {
        // Keep collecting coins until the total number of coins collected by both players equals 10
        if (Coin1 + Coin2 < 10)
        {
            // Check if player 1 has collected a coin
            if (player1.GetComponent<playermovement>().HasCollectedCoin())
            {
                // Increment the number of coins collected by player 1
                Coin1++;

                // Update the textCoin text to reflect the new number of coins collected by player 1
                textCoin.text = Coin1.ToString();
            }

            // Check if player 2 has collected a coin
            if (player2.GetComponent<playermovement2>().HasCollectedCoin())
            {
                // Increment the number of coins collected by player 2
                Coin2++;

                // Update the textCoin text to reflect the new number of coins collected by player 2
                textCoin.text = Coin2.ToString();
            }
        }
        else
        {
            // Check if player 1 collected more coins than player 2
            if (Coin1 > Coin2)
            {
                // Load scene 1
                SceneManager.LoadScene(3);
            }
            else if (Coin2 > Coin1)
            {
                // Load scene 2
                SceneManager.LoadScene(4);
            }

            Debug.Log("Game over!");
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player has collided with a coin
        if (other.transform.tag == "Coin")
        {
            // Check if the player is player 1
            if (gameObject == player1)
            {
                // Increment the number of coins collected by player 1
                Coin1++;

                // Update the textCoin text to reflect the new number of coins collected by player 1
                textCoin.text = Coin1.ToString();
            }
            // Check if the player is player 2
            else if (gameObject == player2)
            {
                // Increment the number of coins collected by player 2
                Coin2++;

                // Update the textCoin text to reflect the new number of coins collected by player 2
                textCoin.text = Coin2.ToString();
            }

            // Play the coin sound effect
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 4);

            // Destroy the coin GameObject
            Destroy(other.gameObject);
        }
    }
}
