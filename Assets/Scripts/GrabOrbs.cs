using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabOrbs : MonoBehaviour {


    public ParticleSystem OrbParticles;
    public AudioSource audioSource;
    public AudioClip OrbsGrab;

    public int OrbsLeft;

    public Text OrbsText;

    [Range(0.0f, 1.0f)]
    public float OrbsVolume;

    void Start()
    {
        OrbsLeft = 5;
        SetCountText();
    }

    void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D objectCollided)
    {
        if (objectCollided.gameObject.tag == "Collectable")
        {
            Inventory.OrbsCount++;

            OrbsLeft = OrbsLeft - 1;

            OrbParticles.Play();

            audioSource.PlayOneShot(OrbsGrab, OrbsVolume);

            print("You found " + Inventory.OrbsCount + " Glimmer Orb(s)!");

            Destroy(objectCollided.gameObject);

            SetCountText();
        }


    }

    void SetCountText()
    {
        OrbsText.text = "Glimmer Orbs Needed: " + OrbsLeft.ToString ();
    }
}