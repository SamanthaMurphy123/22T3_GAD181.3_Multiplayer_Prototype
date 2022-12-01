using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPiker : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;

    public AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag=="Coin"){
            coin++;
            textCoins.text = coin.ToString();

            AudioSource.PlayClipAtPoint(coinSound, transform.position,1);
            Destroy(other.gameObject);
        }
    }
}
