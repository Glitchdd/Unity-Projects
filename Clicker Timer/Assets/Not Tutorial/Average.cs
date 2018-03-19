using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Average : MonoBehaviour {

    public Clicker clicker;

    public Text averageText;


    public int games;
    public int clicks;
    public float average;

	// Use this for initialization
    void Start () {
        averageText.text = average.ToString() + "c/s";
	}
	
	// Update is called once per frame
	void Update () {
        if (clicker.timerManager.GetComponent<Timer>().finished) {
            average = (clicker.clicks / 5 );
            averageText.text = average.ToString() + "c/s";
        }
	}
}
