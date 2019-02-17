using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject laser;
	public float maxHealth = 100;
	public float decrease; 
	public SimpleHealthBar energyBar;
	
	private float health;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject s = Instantiate (laser, transform.position, transform.rotation);
			s.GetComponent<Rigidbody2D> ().AddForce (transform.up * 150);
			
			Energy();
		}
	}
	
	void Energy() {
		health -= decrease;
		energyBar.UpdateBar (health, maxHealth);
	}
}
