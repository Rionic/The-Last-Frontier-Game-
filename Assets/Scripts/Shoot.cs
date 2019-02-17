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
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject s = Instantiate (laser, transform.position, transform.rotation);
			s.GetComponent<Rigidbody2D> ().AddForce (transform.up * 150);
		}
	}
}
