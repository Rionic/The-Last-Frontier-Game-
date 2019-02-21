using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroids : MonoBehaviour
{
	public GameObject asteroidPrefab;
	public float respawnTime = 1f;

	private Vector2 screenBounds;
	private float x_temp;
	private float y_temp;
    private float timer;

	// Start is called before the first frame update
	void Start()
	{
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        timer = respawnTime;
	}

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            x_temp = Random.Range(-screenBounds.x, screenBounds.x);
            y_temp = Random.Range(-screenBounds.y, screenBounds.y);

            if ((x_temp > 1.5f || x_temp < -1.5f) && (y_temp > 1.5f || y_temp < -1.5f))
            {
                GameObject a = Instantiate(asteroidPrefab) as GameObject;
                a.transform.position = new Vector2 (x_temp, y_temp);
                timer = respawnTime;
            }
        }
    }
}
