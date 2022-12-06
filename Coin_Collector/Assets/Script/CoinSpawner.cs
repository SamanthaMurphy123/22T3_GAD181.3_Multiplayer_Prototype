using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // The prefab for the coin
    public GameObject coinPrefab;

    // The bounds of the area where the coins can be spawned
    public Vector2 spawnBounds;

    // The number of coins to spawn
    public int coinCount;

    // The minimum and maximum scale for the coins
    public Vector2 coinScaleRange;

    // The minimum and maximum rotation for the coins
    public Vector2 coinRotationRange;

    void Start()
    {
        // Spawn the specified number of coins
        for (int i = 0; i < coinCount; i++)
        {
            // Keep trying to spawn a coin until we find a valid location
            while (true)
            {
                // Instantiate a new coin
                GameObject coin = Instantiate(coinPrefab);

                // Set the coin's position to a random point within the spawn bounds
                coin.transform.position = new Vector2(
                    Random.Range(-spawnBounds.x, spawnBounds.x),
                    Random.Range(-spawnBounds.y, spawnBounds.y)
                );

                // Check if the coin is colliding with any objects
                bool isColliding = Physics2D.OverlapCircle(coin.transform.position, coin.transform.localScale.x / 2);

                // If the coin is not colliding, we have found a valid location
                if (!isColliding)
                {
                    // Set the coin's scale to a random value within the specified range
                    coin.transform.localScale = new Vector3(
                        Random.Range(coinScaleRange.x, coinScaleRange.y),
                        Random.Range(coinScaleRange.x, coinScaleRange.y),
                        1
                    );

                    // Set the coin's rotation to a random value within the specified range
                    coin.transform.rotation = Quaternion.Euler(
                        0,
                        0,
                        Random.Range(coinRotationRange.x, coinRotationRange.y)
                    );

                    // Exit the loop and continue with the next coin
                    break;
                }
                // If the coin is colliding, destroy it and try again
                else
                {
                    Destroy(coin);
                }
            }
        }
    }
}
