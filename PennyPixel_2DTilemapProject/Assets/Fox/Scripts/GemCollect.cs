/*
 * John Green
 * Assignment 5A
 * Handles player collision with gems, win zone, and loss zone. Implements restart functionality.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GemCollect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<Text>().GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Gem"))
        {
            scoreManager.score++;
        }

        if(collision.gameObject.CompareTag("Loss"))
        {
            scoreManager.scoreText.text = "You Lose. Press R to Restart.";
            gameOver = true;
        }

        if (collision.gameObject.CompareTag("Win"))
        {
            scoreManager.scoreText.text = "You Win! Press R to Restart.";
            gameOver = true;
        }

    }
}
