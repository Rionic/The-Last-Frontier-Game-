using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Transform center;
	public float speed;
	public float score_change = 20f;

	private GameObject player;

	// Use this for initialization
	void Start () {
		transform.up = center.position - transform.position;
		player = GameObject.FindWithTag ("player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distance = center.position - transform.position;
		distance.Normalize ();

		transform.position += distance * speed;
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "Earth" || collider.tag == "bullet")
			GameObject.Destroy (gameObject);
		if (collider.tag == "bullet") {
			Destroy (collider.gameObject);
			player.GetComponent<Player_Score> ().Score_Inc (score_change);
		}
	}
}
