using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	float initialTime = 5f;
	float remainingTime;
	double roundedTime;

    public bool timeLimit;

	public Text timeText;

    public int games;

    bool firstStart = true;

    public bool finished;

    public Clicker clicker;
	
	// Use this for initialization
	void Start ()
	{
        finished = false;
        if (firstStart) {
            games = 0;
        }
		remainingTime = initialTime;
		timeText = GameObject.Find ("Timer Text").GetComponent <Text> ();
		timeText.text = remainingTime.ToString ();
        timeLimit = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
			remainingTime -= Time.deltaTime;

			roundedTime = System.Math.Round (remainingTime, 2);
			timeText.text = roundedTime.ToString ();

	



		if (remainingTime < 0) {
            timeText.fontSize = 26;
			timeText.text = "TIME LIMIT! Press R to Replay";
			Time.timeScale = 0;
            timeLimit = true;
            games++;
            finished = true;
		}

		if (Input.GetKeyDown (KeyCode.R)) {
            finished = false;
			Time.timeScale = 1;
            timeLimit = false;
            clicker.clicks = 0;
            clicker.clickText.text = "0";
            remainingTime = initialTime;
		}
	}
}
