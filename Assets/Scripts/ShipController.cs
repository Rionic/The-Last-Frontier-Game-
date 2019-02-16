using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed; //control the speed of spaceship

    private Rigidbody2D rb2D; 

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D> (); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2D.AddForce(movement * speed);
    }
}
