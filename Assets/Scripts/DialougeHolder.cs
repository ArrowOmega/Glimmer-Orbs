using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeHolder : MonoBehaviour
{

    public string dialouge;
    private DialougeManager NPC;

    // Start is called before the first frame update
    void Start() {
        NPC = FindObjectOfType<DialougeManager>();

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerStay2D(Collider2D objectCollided)
    {
        if (objectCollided.gameObject.tag == "NPC")
        {
            if (gameObject.name == "Player")
            {
                if (Input.GetKeyUp(KeyCode.S))
                {
                    NPC.Show(dialouge);
                }
            }
        }
    }
}
