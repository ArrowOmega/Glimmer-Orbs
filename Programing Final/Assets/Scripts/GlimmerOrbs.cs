using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlimmerOrbs : MonoBehaviour
{
    public int pointsToAdd;
    public GameObject glimmerOrbs;
    public GameObject glimmerParticle;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Moving>() == null)
            return;

        GrabOrbs.AddPoints(pointsToAdd);
        Destroy(gameObject);
        Instantiate(glimmerParticle, glimmerOrbs.transform.position, glimmerOrbs.transform.rotation);
    }
}
