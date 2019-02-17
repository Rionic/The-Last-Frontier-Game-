using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollisions : MonoBehaviour
{
	public float timer = 3f;

	private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
		timeLeft = timer;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("collided");
        if (collider.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
			Destroy (collider.gameObject);
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