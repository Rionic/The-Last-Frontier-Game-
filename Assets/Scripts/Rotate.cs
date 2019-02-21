using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;

		if (Input.GetKey (KeyCode.A)) {
			position.x = position.x - 0.1f;
		} else if (Input.GetKey(KeyCode.D)) {
			position.x = position.x + 0.1f;
		} else if (Input.GetKey (KeyCode.W)) {
			position.y = position.y + 0.1f;
		} else if (Input.GetKey (KeyCode.S)) {
			position.y = position.y - 0.1f;
		}
		this.transform.position = position;

		Ship_Turn ();
	}

	void Ship_Turn() {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 mouseToCharacter = mousePos - transform.position;
		float angle = Mathf.Atan2 (mouseToCharacter.x, mouseToCharacter.y);

		float deg = angle * (180 / Mathf.PI);

		transform.rotation = Quaternion.Euler(new Vector3(0,0, -deg));
	}
}
