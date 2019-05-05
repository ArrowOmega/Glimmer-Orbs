using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public string start;
    public string title;
    public string instructions;
    public string winRestart;

    public void NewGame()
    {
        SceneManager.LoadScene(start);

        PlayerPrefs.SetInt("CurrentPlayerScore", 0);

    }

    public void Controls()
    {
        SceneManager.LoadScene(instructions);
    }

    public void TitleMenu()
    {
        SceneManager.LoadScene(title);
    }
}

