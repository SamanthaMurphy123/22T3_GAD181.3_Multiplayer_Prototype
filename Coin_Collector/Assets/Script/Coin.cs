using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player") 
        {
            playermovement.numberOfCoin++;
            Destroy(gameObject);
        }
        if(collision.transform.tag == "Player")
        {
            playermovement2.numberOfCoin++;
            Destroy(gameObject);
        }
    }
}