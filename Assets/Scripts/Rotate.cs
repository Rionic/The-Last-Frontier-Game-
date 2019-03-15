using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 dir = Vector3.zero;
    private Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR
        Vector3 position = this.transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x = position.x - 0.1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x = position.x + 0.1f;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            position.y = position.y + 0.1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.y = position.y - 0.1f;
        }
        this.transform.position = position;
#else
        float speed = 10f;

        dir.x = Input.acceleration.x * speed;
        dir.y = Input.acceleration.y * speed;
        
#endif
        rb.velocity = dir;

        Vector3 touchPos = Vector3.zero;
        Vector3 touchToCharacter = Vector3.zero;

        float deg, angle;

#if UNITY_EDITOR
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseToCharacter = mousePos - transform.position;
        angle = Mathf.Atan2(mouseToCharacter.x, mouseToCharacter.y);

        deg = angle * (180 / Mathf.PI);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, -deg));
#endif

        for (int i = 0; i < Input.touchCount; ++i)
            if (Input.GetTouch(i).phase == TouchPhase.Moved)
            {
                touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);
                touchToCharacter = touchPos - transform.position;

                touchToCharacter.Normalize();
                angle = Mathf.Atan2(touchToCharacter.x, touchToCharacter.y) * Mathf.Rad2Deg;
                // Quaternion rot = Quaternion.LookRotation(touchToCharacter, Vector3.zero);
                transform.rotation = Quaternion.Euler(0f, 0f, -angle);
            }


        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vector3 mouseToCharacter = mousePos - transform.position;

        //dir = Vector3.RotateTowards(dir, transform.forward, 3.14f, 1);
        //transform.Translate(dir * speed);
    }
}
