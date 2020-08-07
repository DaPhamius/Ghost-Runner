using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int score;
    public Text scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle") && score < 10)
        {
            score++;
        }
        else if (other.CompareTag("Obstacle") && score < 40)
        {
            score = score + 3;
        }
        else if (other.CompareTag("Obstacle") && score < 70)
        {
            score = score + 4;
        }
        else if (other.CompareTag("Obstacle") && score < 120)
        {
            score = score + 4;
        }
        else if (other.CompareTag("Obstacle") && score < 180)
        {
            score = score + 5;
        }
        else if (other.CompareTag("Obstacle") && score < 250)
        {
            score = score + 6;
        }
        else if (other.CompareTag("Obstacle") && score < 350)
        {
            score = score + 7;
        }
        else if (other.CompareTag("Obstacle") && score < 450)
        {
            score = score + 8;
        }
        else if (other.CompareTag("Obstacle") && score < 590)
        {
            score = score + 9;
        }
        else if (other.CompareTag("Obstacle") && score >= 590)
        {
            score = score + 10;
        }

                
    }
}
