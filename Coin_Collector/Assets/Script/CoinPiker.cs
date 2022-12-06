using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPiker : MonoBehaviour
{
    public float Coin1 = 0;
    public float Coin2 = 0;

    public TextMeshProUGUI textCoin;

    public AudioClip coinSound;

    public GameObject player1;
    public GameObject player2;

    [SerializeField] 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Coin" && gameObject == player1)
        {
            Coin1++;
            textCoin.text = Coin1.ToString();

            AudioSource.PlayClipAtPoint(coinSound, transform.position,1);
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Coin" && gameObject == player2)
        {
            Coin2++;
            textCoin.text = Coin2.ToString();

            AudioSource.PlayClipAtPoint(coinSound, transform.position, 1);
            Destroy(other.gameObject);

        }
        

        
        
    }

    //public void WinCondition()
    //{
    //    if ()
    //    {

    //    }

    //}
}
