using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertSpike : MonoBehaviour
{
    float speed = -2f;

    

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed); // talking to the rigidbody of the platform and setting its velocity


        if (transform.position.y < -8.22f)
        {
            transform.position = new Vector3(0.18f, -5.91f, 1000f);
        }
        //If the y position is less than -8.22 it resets the y to -5.91
    }
}
