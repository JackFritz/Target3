using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if statement that loads the next scene
        if (collision.gameObject.name == "Player")
        {
            Application.LoadLevel("LevelTest");
        }

    }
}
