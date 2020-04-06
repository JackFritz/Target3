using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("LevelTest"); //goes to level on click
    }

    public void title()
    {
        SceneManager.LoadScene("MenuScene"); //goes back to title screen on click
    }

    public void instructions()
    {
        SceneManager.LoadScene("Instructions"); //goes to instructions screen on click
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits"); //goes to credits screen on click
    }
}
