using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public int initialTime = 5;
	public float remainingTime;
	double roundedTime;

	public Text timerText;

	public bool timeLimit = false;

	public bool finished;

	// Use this for initialization
	void Start () {
		remainingTime = initialTime;
		timeLimit = false;
		timerText.text = "0";
		finished = false;
	}

	// Update is called once per frame
	void Update () {
        remainingTime -= Time.deltaTime;
		roundedTime = System.Math.Round(remainingTime, 2);

		timerText.text = roundedTime	.ToString();

		if (remainingTime < 0.001) {
			Time.timeScale = 0;
			timeLimit = true;
			remainingTime = 0.000000000000000000000000000000000000000f;
			timerText.text = "TIME LIMIT! Press R to Replay";
			finished = true;
		}
	}
}
