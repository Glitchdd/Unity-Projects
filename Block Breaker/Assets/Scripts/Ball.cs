using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody2D rb;
	private Paddle paddle;
    private AudioSource audio;

	private Vector3 paddleToBallVector;

	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		paddle = Object.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
        audio = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	//Lock the ball relative to the paddle.
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}

		// Wait for a mouse click to launch
		if (Input.GetMouseButtonDown(0)) {
		print ("Mouse clicked, launch ball");
		hasStarted = true;
		rb.velocity = new Vector2 (2f, 10f);
		}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.6f), Random.Range(0f, 0.6f));

        if (hasStarted)
        {
            audio.Play();
            rb.velocity += tweak;
        }
    }
}
