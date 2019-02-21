using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthDamage : MonoBehaviour {

	public float maxHealth = 100;
	public float damage; 
	public SimpleHealthBar healthBar;
	public GameObject explosion;

	private float health;
	private bool hit;
	private float hitInterval = 0.35f;
	private float temp;
	private SpriteRenderer spriteRend;
	private Sprite earth;
	private GameObject explosion_sound;
	private AudioSource explosion_src;

	// Use this for initialization
	void Start () {
		health = maxHealth;
		hit = false;
		temp = hitInterval;
		spriteRend = GetComponent<SpriteRenderer>();
		earth = spriteRend.sprite;
		explosion_sound = GameObject.Find ("Explosion Sound");
		explosion_src = explosion_sound.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0) {
			SceneManager.LoadScene("GameOver");
		}
		
		if (hit == true) {
			temp -= Time.deltaTime;
			if (temp < 0) {
				spriteRend.sprite = earth;
				temp = hitInterval;
				hit = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "enemy") {
			TakeDamage ();
			hit = true;
			spriteRend.sprite = explosion.GetComponent<SpriteRenderer>().sprite;
			explosion_src.Play ();
		}
	}

	void TakeDamage() {
		health -= damage;
		healthBar.UpdateBar (health, maxHealth);
	}
}