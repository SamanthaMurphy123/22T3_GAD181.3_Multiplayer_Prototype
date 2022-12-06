using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePoint : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    // Update is called once per frame
    void Update()
    {
        Vector3 middlePoint = (player1.transform.position + player2.transform.position) / 2;

        this.transform.position = middlePoint;


    }
}
