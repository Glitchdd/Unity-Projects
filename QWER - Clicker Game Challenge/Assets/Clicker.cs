using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{

    public int[] clicks = new int[4];

    public Text[] texts = new Text[4];

    public GameObject timer;

	// Use this for initialization
	void Start ()
	{
        // Setting all clicks to 0
        clicks[0] = 0; clicks[1] = 0; clicks[2] = 0; clicks[3] = 0;
		texts[0] = GameObject.Find ("Q Clicks").GetComponent <Text> ();
        texts[1] = GameObject.Find("W Clicks").GetComponent<Text>();
        texts[2] = GameObject.Find("E Clicks").GetComponent<Text>();
       // texts[3] = GameObject.Find("R Clicks").GetComponent<Text>();

        print(texts[0].gameObject.name);
        print(texts[1].gameObject.name);
        print(texts[2].gameObject.name);
       // print(texts[3].gameObject.name);

        texts[0].text = "0";
        texts[1].text = "0";
        texts[2].text = "0";
        texts[3].text = "0";
        timer = GameObject.Find("Timer");

	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.Q) && clicks[0] != 10) 
        {
            clicks[0]++;
            texts[0].text = clicks[0].ToString();
        }

        if (Input.GetKeyDown(KeyCode.W) && clicks[1] != 10)
        {
            clicks[1]++;
            texts[1].text = clicks[1].ToString();
        }

        if (Input.GetKeyDown(KeyCode.E) && clicks[2] != 10)
        {
            clicks[2]++;
            texts[2].text = clicks[2].ToString();
        }

        if (Input.GetKeyDown(KeyCode.R) && clicks[3] != 10)
        {
            clicks[3]++;
            texts[3].text = clicks[3].ToString();
        }
	}
}
