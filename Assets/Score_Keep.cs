using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score_Keep : MonoBehaviour {

	private Transform loc;

	// Use this for initialization
	void Start () {
		loc = GameObject.FindWithTag ("center").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "GameOver") {
			transform.position = loc.position;
		}
	}
}
