using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float speed = 15f;
    [SerializeField] float padding = 0.5f;

    float xMin;
    float xMax;
    

	// Use this for initialization
	void Start () {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        xMin = leftMost.x + padding;
        xMax = rightMost.x - padding;
	}
	
	// Update is called once per frame
	void Update () {
        // move left and right
        Move();
        //restrict the player to the screen space
        ClampPos();
 	}

    void Move () {
        if (Input.GetAxis("Horizontal") > 0)
        {
            // move right
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            // move left
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void ClampPos () {
        float newX = Mathf.Clamp(transform.position.x, xMin, xMax);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
