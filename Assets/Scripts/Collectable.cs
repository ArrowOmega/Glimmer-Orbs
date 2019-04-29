using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{

    public Sprite activePortal;

    public int orbsHeld;
	public int orbsNeeded;

    // Use this for initialization
    public void Start ()
    {
        orbsNeeded = GameObject.FindGameObjectsWithTag("Collectable").Length;
	}

    void OnTriggerEnter2D (Collider2D col)
	{
		//print (col.gameObject.name);
		if (col.gameObject.tag == "Respawn") 
		{
			print ("Restarting Level");
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Level1");
            {
                print("You died! Try again.");
                UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
            }            }            
		else if (col.gameObject.tag == "Collectable")
            {
                orbsHeld++;
                Destroy(col.gameObject);
                if (orbsHeld == orbsNeeded);
            {
                GameObject.FindGameObjectWithTag("Teleporter").GetComponent<SpriteRenderer>().sprite = activePortal;
            }
        }
        else if (col.gameObject.tag == "Teleporter" && (orbsHeld == orbsNeeded))
        {
            GetComponent<Transform>().position = new Vector2(75f, -20f);
        }
    }
}