using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickScript : MonoBehaviour
{

    public int score = 0;

    public Text scoreText;

    public TimerScript timerScript;

    // Use this for initialization
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !t.timeLimit)
        {
            score++;
            scoreText.text = score.ToString();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            timerScript.timeLimit = false;
            timerScript.remainingTime = timerScript.initialTime;
            score = 0;
            scoreText.text = score.ToString();
            timerScript.timerText.text = timerScript.remainingTime.ToString();
            timerScript.finished = false;
        }
    }
}




