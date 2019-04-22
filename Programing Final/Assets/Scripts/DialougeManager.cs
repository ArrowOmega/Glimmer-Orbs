using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager: MonoBehaviour {

    public GameObject DBox;
    public Text DText;

    public bool dialogActive;
    
    void Start() {

    }

    void Update() 
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.S))
        {
            DBox.SetActive(false);
            dialogActive = false;
        }
    }

    public void Show (string dialouge)
    {
        dialogActive = true;
        DBox.SetActive(true);
        DText.text = dialouge;
    }
}