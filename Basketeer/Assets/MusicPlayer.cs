using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("Duplicate MusicPlayer self destructing");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
    	int numberone = 2;
    	float numberoneDetail = 2.143;
    	string word = "abo omk";
    	bool isDead = false;

    	print (numberone + word);
    }
}
