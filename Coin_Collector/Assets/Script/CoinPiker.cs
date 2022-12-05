using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPiker : MonoBehaviour
{
    private float Coin = 0;

    public TextMeshProUGUI textCoin;

    public AudioClip coinSound;

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag=="Coin"){
            Coin++;
            textCoin.text = Coin.ToString();

            AudioSource.PlayClipAtPoint(coinSound, transform.position,1);
            Destroy(other.gameObject);
        }
    }

  
}
