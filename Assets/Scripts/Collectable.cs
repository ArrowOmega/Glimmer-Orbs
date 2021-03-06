using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public Sprite activePortal;
    public LevelManager levelManager;
    public int orbsHeld;
    public int orbsNeeded;
    public string levelToLoad;

    // Use this for initialization
    public void Start()
    {
        orbsNeeded = GameObject.FindGameObjectsWithTag("Collectable").Length;
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Collectable")
        {
            orbsHeld++;
            Destroy(col.gameObject);
            if (orbsHeld >= orbsNeeded)
            {
                GameObject.FindGameObjectWithTag("Teleporter").GetComponent<SpriteRenderer>().sprite = activePortal;
            }
        }
        else if (col.gameObject.tag == "Teleporter" && (orbsHeld >= orbsNeeded))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}