using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightUpMove2 : MonoBehaviour
{
    float speed = 1f;

  
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed); // talking to the rigidbody of the platform and setting its velocity


        if (transform.position.y > 3.75f)
        {
            transform.position = new Vector3(10.92f, -7.25f, 1000f);
        }
        //If the y position is greater than 3.75 it resets the y to -7.25
    }
}
