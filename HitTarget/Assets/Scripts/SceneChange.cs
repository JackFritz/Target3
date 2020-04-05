using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Credits()// Press Credits button
    {
        SceneManager.LoadScene("Credits");// Hey, that's us!!!
    }

    public void Instructions()// Press Instructions button
    {
        SceneManager.LoadScene("Instructions");// This is how you become a pro gamer
    }

    public void StartGame()// Press Start button
    {
        SceneManager.LoadScene("Level1");// We might only make 1 level, but I am gonna call it level 1
    }

    public void StoryTime()// Press Story button
    {
        SceneManager.LoadScene("Story1");// Begins the extensive lore
    }

    public void Story2()// Press Next Button
    {
        SceneManager.LoadScene("Story2");// More Story
    }

    public void Story3()// Press Next Button
    {
        SceneManager.LoadScene("Story3");// More Story
    }

    public void Story4()// Press Next Button
    {
        SceneManager.LoadScene("Story4");// More Story
    }

    public void Story5()// Press Next Button
    {
        SceneManager.LoadScene("Story5");// More Story
    }
}
