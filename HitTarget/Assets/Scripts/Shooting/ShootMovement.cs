//https://youtu.be/LNLVOjbrQj4
//This video helped get the shooting to follow the mouse

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); // converts pixel units to world units which is what Unity is using. ScreenToWorldPoint follows mouse.
    }

    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //Helps smooth out the movement. Use WASD or Arrow keys to move.
        //Drag rigidbody 2d from player into rigidbody slot on script.

        Vector2 lookDir = mousePos - rb.position; //places the cursor wherever the player is.
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //Atan2 takes the y and x coordinates (Yes in that order) of the player and then the vector that the mouse makes, and finds the tangent angle...Yay...Geometry.
        //Rad2Deg literally translates to Radians to Degrees.

        rb.rotation = angle; //angle that was just calculated.
    }
}
