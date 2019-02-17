using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployStars : MonoBehaviour
{
    public GameObject starsPrefab;
    public float respawnTime = 3.0f;

    private Vector2 screenBounds;
    private int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        StartCoroutine(starWave());
    }

    private void spawnStar()
    {
        if (counter <= 30)
        {
            GameObject c = Instantiate(starsPrefab) as GameObject;
            c.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.y), Random.Range(-screenBounds.y, screenBounds.y));
            counter++;
        }
    }

    IEnumerator starWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnStar();
        }
    }
}

