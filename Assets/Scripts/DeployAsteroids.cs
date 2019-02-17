using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroids : MonoBehaviour
{
	public GameObject asteroidPrefab;
	public float respawnTime = 1.0f;

	private Vector2 screenBounds;
	private int counter = 0;


	// Start is called before the first frame update
	void Start()
	{
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
		StartCoroutine(asteroidWave());
	}

	private void spawnEnemy()
	{
		if (counter <= 20)
		{
			GameObject a = Instantiate(asteroidPrefab) as GameObject;
			a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.y), Random.Range(-screenBounds.y, screenBounds.y));
			counter++;
		}
	}

	IEnumerator asteroidWave() {
		while (true) {
			yield return new WaitForSeconds(respawnTime);
			spawnEnemy();
		}
	}
}
