using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public string startLevel;

    public void NewGame()
    {
        SceneManager.LoadScene(startLevel);

        PlayerPrefs.SetInt("CurrentPlayerScore", 0);

    }
}