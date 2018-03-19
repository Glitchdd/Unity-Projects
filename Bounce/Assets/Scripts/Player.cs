using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;
    GameObject waypoint;
    LevelManager lm;

    public float speed;
    public float jumpPower;

    public bool grounded;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded) {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground") {
            grounded = true;
        }
        if (other.gameObject.tag == "teleporter")
        {
            waypoint = GameObject.Find("Waypoint");
            transform.position = waypoint.transform.position;
        }
        if (other.gameObject.tag == "win")
        {
            lm.LoadLevel("Win");
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            grounded = false;
        }
    }
}
