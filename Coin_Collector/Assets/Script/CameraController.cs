using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   // public Transform player1;
  //  public Transform player2;
    public Transform middlePoint;

    private void Update()
    {
        Follow();
    }

    private void Follow()
    {
        transform.position = new Vector3(middlePoint.position.x, middlePoint.position.y, transform.position.z);
       // transform.position = new Vector3(player2.position.x, player2.position.y, transform.position.z);
    }
}
