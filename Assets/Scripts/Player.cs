using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject health1, health2, health3;
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health;

    public GameObject effect;

    public GameObject gameOver;

    public GameObject spawner;



    // Update is called once per frame

    private void Start()
    {
        health = 3;
        health1.gameObject.SetActive(true);
        health2.gameObject.SetActive(true);
        health3.gameObject.SetActive(true);

    }

    void Update () {

        if (health <= 0)
        {
            spawner.SetActive(false);
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        // health
        switch (health)
        {
            case 3:
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(true);
                health3.gameObject.SetActive(true);
                break;
            case 2:
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(true);
                health3.gameObject.SetActive(false);
                break;
            case 1:
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(false);
                health3.gameObject.SetActive(false);
                break;
            case 0:
                health1.gameObject.SetActive(false);
                health2.gameObject.SetActive(false);
                health3.gameObject.SetActive(false);
                break;

        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);

            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {

            Instantiate(effect, transform.position, Quaternion.identity);

            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);

        }
    }
}
