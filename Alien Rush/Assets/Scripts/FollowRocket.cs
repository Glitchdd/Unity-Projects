using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRocket : MonoBehaviour {

    public Transform rocket;

    Transform rocketPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rocketPos = transform;
        rocketPos.position = new Vector3(transform.position.x, rocket.position.y + 3.5f, transform.position.z);
        transform.position = rocketPos.position;
	}
}
