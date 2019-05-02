using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Moving player;
    public GameObject currentCheckPoint;
    public float respawnDelay;
    private float gravityStore;
    private CameraController camera;

    public void Start()
    {
        player = FindObjectOfType<Moving>();

        camera = FindObjectOfType<CameraController>();
    }
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        camera.isFollowing = false;

        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);

        player.transform.position = currentCheckPoint.transform.position;

        camera.isFollowing = true;

        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
    }
}
