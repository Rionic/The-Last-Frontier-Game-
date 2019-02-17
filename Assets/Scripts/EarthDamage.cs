using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthDamage : MonoBehaviour {

	public float maxHealth = 100;
	public float damage; 
	public SimpleHealthBar healthBar;

	private float health;

	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "enemy") {
			TakeDamage ();
		}
	}

	void TakeDamage() {
		health -= damage;
		healthBar.UpdateBar (health, maxHealth);
	}
}
