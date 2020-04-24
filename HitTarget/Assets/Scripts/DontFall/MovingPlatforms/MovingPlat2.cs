using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat2 : MonoBehaviour
{

    float speed = 0.5f;


    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0); // talking to the rigidbody of the platform and setting its velocity


        if (transform.position.x > 5.67f)
        {
            transform.position = new Vector3(-1.7f, -1.92f, 1000f);
        }
        //If the x position is greater than 5.67 it resets the x to -1.7  
    }
}
