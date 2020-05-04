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
        SceneManager.LoadScene("LevelSelect");// Load level select
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

    public void MainMenu()// Press Back Button or Main Menu Button
    {
        SceneManager.LoadScene("MainMenu");// To the menu
    }

    public void Practice()// Press practice level picture
    {
        SceneManager.LoadScene("LevelTest");// Loads practice level
    }
    public void QuickDescent()// Press picture of vertical level
    {
        SceneManager.LoadScene("QuickDescent");// Load level quick descent
    }
    public void DontFall()// Press picture of spike level
    {
        SceneManager.LoadScene("DontFall");// Load level don't fall... seriously
    }

    public void WinScreen() //press back button
    {
        SceneManager.LoadScene("WinScreen");//Load win screen... and that's all she wrote
    }
}
