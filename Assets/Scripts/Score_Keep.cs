using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Keep : MonoBehaviour {

	private GameObject score;

	// Use this for initialization
	void Start () {
		score = GameObject.FindWithTag ("score_num");
		gameObject.GetComponent<Text> ().text = score.GetComponent<Score> ().score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
