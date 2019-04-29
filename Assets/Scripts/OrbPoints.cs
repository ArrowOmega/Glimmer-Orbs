using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbPoints : MonoBehaviour
{
    public int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Moving>() == null)
            return;

        OrbCounter.AddPoints(pointsToAdd);
        Destroy(gameObject);
    }
}

