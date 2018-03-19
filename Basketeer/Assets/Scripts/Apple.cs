using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : MonoBehaviour {

    public scoreManager score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<scoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "basket") {
            Debug.Log("Add Point!");
            score.score++;
            score.scoreText.text = "Score: " + score.score.ToString();
            score.PlayPop();
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Lose") {
            Time.timeScale = 0;
            Destroy(gameObject);
            score.loseText.text = "You Lost!\npress R to replay";
            score.PlayLose();
        }
    }
}
