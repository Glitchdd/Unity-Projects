using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartManager : MonoBehaviour {

    public Rocket rocket;

    public Text startText;

    public GameObject title;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!rocket.startGame) {
            startText.text = "Press SPACE to Play";
            title.SetActive(true);
        } else {
            startText.text = "";
            title.SetActive(false);
        }
	}
}
