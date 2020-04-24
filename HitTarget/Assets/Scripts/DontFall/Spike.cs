using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if statement that loads the next scene
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("DontFall");
        }

    }
}
