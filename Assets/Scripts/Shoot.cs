using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject laser;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject s = Instantiate (laser, transform.position, transform.rotation);
			s.transform.parent = transform;
			s.GetComponent<Rigidbody2D> ().AddForce (transform.up * 150);
		}
	}
}
