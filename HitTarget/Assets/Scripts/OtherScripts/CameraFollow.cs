using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerC;

    void FixedUpdate()
    {
        transform.position = new Vector3(playerC.position.x, playerC.position.y, transform.position.z);
    }
}