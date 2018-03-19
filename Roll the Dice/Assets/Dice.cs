using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {

	public Sprite[] sprites = new Sprite[6];
	int diceScore;

	public void RollDice () {
			diceScore = Random.Range(1,7);
			GetComponent<SpriteRenderer>().sprite = sprites[diceScore - 1];
			print(diceScore);
	}
}
