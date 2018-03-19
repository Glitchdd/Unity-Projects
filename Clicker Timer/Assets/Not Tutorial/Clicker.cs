using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{

	public int clicks;

	public Text clickText;

    public GameObject timerManager;

	// Use this for initialization
	void Start ()
	{
		clicks = 0;
		clickText = GameObject.Find ("Click Text").GetComponent <Text> ();
		clickText.text = "0";
        timerManager = GameObject.Find("Timer Manager");
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetMouseButtonDown (0) && !timerManager.GetComponent<Timer>().timeLimit) {
			print ("Mouse Pressed");
			clicks++;
			clickText.text = clicks.ToString ();
		}
	}
}
