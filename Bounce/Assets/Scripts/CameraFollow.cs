using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject player;

    GameObject camera;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newPos = new Vector3(player.transform.position.x, 0f, -10);
        camera.transform.position = newPos;
	}
}
