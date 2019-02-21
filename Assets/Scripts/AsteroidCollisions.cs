using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollisions : MonoBehaviour
{
	public float timer = 3f;
	public float damage = 20f;
	
	private GameObject player;
	private float timeLeft;
	private float score_change = 10f;

    // Start is called before the first frame update
    void Start()
    {
		timeLeft = timer;
		player = GameObject.FindWithTag("player");
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "bullet")
        {
			player.GetComponent<Shoot>().IncreaseEnergy(damage);
			player.GetComponent<Player_Score> ().Score_Inc (score_change);
			Destroy (gameObject);
			Destroy (collider.gameObject);
			GameObject.Find ("Hit Sound").GetComponent<AudioSource> ().Play ();
        }
    }

    // Update is called once per frame
	void Update() {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			GameObject.Destroy (gameObject);
			timeLeft = timer;
		}
	}
}