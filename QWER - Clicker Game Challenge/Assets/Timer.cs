using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
	float remainingTime;
	double roundedTime;

    public bool timeLimit;

	public Text timeText;

    public Clicker clicker;
	
	// Use this for initialization
	void Start ()
	{
		remainingTime = 0;
		timeText = GameObject.Find ("TimerText").GetComponent<Text> ();
		timeText.text = remainingTime.ToString ();
        timeLimit = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
			remainingTime += Time.deltaTime;

			roundedTime = System.Math.Round (remainingTime, 2);
			timeText.text = roundedTime.ToString ();

	



        if (clicker.clicks[0] == 10 && clicker.clicks[1] == 10 && clicker.clicks[2] == 10 && clicker.clicks[3] == 10) {
            timeText.text = "You WIN in " + roundedTime + "s Press Escape to Restart";
			Time.timeScale = 0;
            timeLimit = true;
		}

        if (Input.GetKeyDown (KeyCode.Escape)) {
            Time.timeScale = 1;
            Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
