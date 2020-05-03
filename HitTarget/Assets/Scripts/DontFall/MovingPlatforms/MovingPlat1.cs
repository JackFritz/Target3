using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat1 : MonoBehaviour
{
    float speed = -0.3f;
   
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0); // talking to the rigidbody of the platform and setting its velocity


        if (transform.position.x < -0.46f)
        {
            transform.position = new Vector3(5.37f, 0.67f, 1000f);
        }
        //If the x position is less than -0.46 it resets the x to 5.37
    }
}
