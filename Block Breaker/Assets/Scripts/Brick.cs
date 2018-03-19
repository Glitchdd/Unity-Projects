using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public AudioClip crack;
    public GameObject smoke;
    private LevelManager levelManager;

	private int timesHit;
    public static int breakableCount = 0;

    private bool isBreakable;

    public Sprite[] hitSprites;

	// Use this for initialization
	void Start () {
        isBreakable = (this.tag == "Breakable");

        if (isBreakable) {
            breakableCount++;
            print(breakableCount);
        }

        levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionExit2D(Collision2D collision) {
        AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable) {
            HandleHits(); 
        }
    }

    void HandleHits () {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits) {
            breakableCount--;
            levelManager.BrickDestroyed();
            PuffSmoke();
            Destroy(gameObject);
        } else {
            int spriteIndex = timesHit - 1;
            if (hitSprites[spriteIndex] != null)
            {
                this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
            } else {
                Debug.LogError("Brick sprite missing");
            }
        }
	}

    void PuffSmoke () {
        GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity) as GameObject;
        var main = smokePuff.GetComponent<ParticleSystem>().main;
        main.startColor = GetComponent<SpriteRenderer>().color;
    }

	void SimulateWin () {
		levelManager.LoadNextLevel();
	}
}
