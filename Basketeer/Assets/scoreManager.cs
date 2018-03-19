using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

    public Text scoreText;
    public Text loseText;

    public GameObject apple;

    public AudioSource popAudio;
    public AudioSource loseAudio;

    public float score;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.text = "Score: " + 0;
        loseText.text = "";

        InvokeRepeating("SpawnApples", 4, 1);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)) {
            Application.LoadLevel("Game");
            Time.timeScale = 1;
        }
	}

    void SpawnApples () {
        Vector3 spawnPosition = new Vector3(Random.Range(-6,7), 4, 0);
        Instantiate(apple, spawnPosition, transform.rotation);
    }

    public void PlayPop () { 
        popAudio.Play();
    }

    public void PlayLose()
    {
        loseAudio.Play();
    }
}
