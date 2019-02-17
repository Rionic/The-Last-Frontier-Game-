using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject spawnPrefab;
	public float spawnInterval;

	private float timer = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) {
			Spawn ();
			timer = spawnInterval;
		}
	}

	void Spawn() {
		Vector3 randomPosition = new Vector3(UnityEngine.Random.Range(-40f, 40f), 0, 0);
		Object.Instantiate (spawnPrefab, randomPosition, Quaternion.identity);
	}
}
