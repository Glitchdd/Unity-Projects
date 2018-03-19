using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

    public GameObject obs1;
    public GameObject obs2;
    public GameObject obs3;

    int whoToSpawn;

    int spawnNumber;

    Vector3 spawnPos;

	// Use this for initialization
	void Start () {
        spawnNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (spawnNumber < 200) {

            if (spawnNumber != 0)
            {
                whoToSpawn = Random.Range(1, 4);

                spawnPos = new Vector3(transform.position.x, spawnNumber * 10, transform.position.z);
                switch (whoToSpawn)
                {
                    case 1:
                        Instantiate(obs1, spawnPos, transform.rotation);
                        break;
                    case 2:
                        Instantiate(obs2, spawnPos, transform.rotation);
                        break;
                    case 3:
                        Instantiate(obs3, spawnPos, transform.rotation);
                        break;
                }
            }

            spawnNumber++;
        }
	}
}
