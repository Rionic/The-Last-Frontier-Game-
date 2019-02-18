using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("collided");
        if (collider.gameObject.tag == "enemy")
        {
            Destroy(gameObject); // destroy the ship 
         }
    }

    // Update is called once per frame
    void Update()
    {
    }
}