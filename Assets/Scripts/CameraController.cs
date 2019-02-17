using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}

	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	
		Vector3 temp = transform.position;
		temp.x = Mathf.Clamp (transform.position.x, -5.5f, 5.5f);
		temp.y = Mathf.Clamp (transform.position.y, -3.5f, 3.5f);
		transform.position = temp;
	}
}
