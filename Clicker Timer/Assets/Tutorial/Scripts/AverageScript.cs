using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AverageScript : MonoBehaviour {

	public ClickScript clickScript;

	public Text averageText;

	int averageScore;

	// Use this for initialization
	void Start () {
		averageScore = 0;
	}

	// Update is called once per frame
	void Update () {
		if (clickScript.timerScript.finished) {
			averageScore = (clickScript.score / clickScript.timerScript.initialTime);
			averageText.text = averageScore + "c/s";
		}
	}
}
