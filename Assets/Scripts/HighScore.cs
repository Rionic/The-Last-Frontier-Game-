using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    private GameObject text;

	// Use this for initialization
	void Start () {
        text = GameObject.FindWithTag("high_score");
        text.GetComponent<Text>().text = PlayerPrefs.GetFloat("High Score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
