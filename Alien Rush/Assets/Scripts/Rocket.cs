using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rocket : MonoBehaviour {

    public float xSpeed;
    public float ySpeed;
    public bool startGame;
    public int score = 0;

    public Text scoreText;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        startGame = false;
        score = 0;
	}

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (startGame)
        {
            // Move Up Continuously
            rb.velocity = Vector2.up * ySpeed;

            // Moving Left and Right
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + xSpeed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - xSpeed, transform.position.y, transform.position.z);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            startGame = true; 
        }
        // Limit movement to edges of camere
        if (transform.position.x <= -9f) 
        {
            transform.position = new Vector3(-8.99f, transform.position.y, transform.position.z); 
        }

        if (transform.position.x >= 9f)
        {
            transform.position = new Vector3(8.99f, transform.position.y, transform.position.z);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "score") {
            score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "death")
        {
            Application.LoadLevel("Game");
            print("game over"); 
        }
    }
}
