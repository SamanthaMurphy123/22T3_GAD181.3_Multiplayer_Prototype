using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPiker : MonoBehaviour
{
    // The number of coins that the picker has picked up
    public int coins = 0;

    // The text element that will display the number of coins picked up
    public TextMeshProUGUI textCoins;

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the picker collides with a coin, pick it up
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            textCoins.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }
}