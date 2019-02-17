using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Transform center;
	public float speed;

	// Use this for initialization
	void Start () {
		transform.up = center.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distance = center.position - transform.position;
		distance.Normalize ();

		transform.position += distance * speed;
	}
}
