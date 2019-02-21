using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

	private GameObject score_text;
	private float score;

	// Use this for initialization
	void Start () {
		score = 0;
		score_text = GameObject.FindWithTag ("score");

		Update_Score ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Score_Inc (float damage) {
		score += damage;
		Update_Score ();
	}

	private void Update_Score () {
		score_text.GetComponent<Text>().text = score.ToString ();
		GameObject.FindWithTag ("score_num").GetComponent<Score>().score = score;
	}
}
