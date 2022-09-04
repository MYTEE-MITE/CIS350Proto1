/*
 * John Green
 * Assignment 2 Challenge
 * Manages score and win/loss conditions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;
    public static int score;
    private bool gameOver;
    private bool won;
    public GameObject player;

    void Start()
    {
        score = 0;
        gameOver = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if(player.transform.position.y > 80 || player.transform.position.y <-51)
        {
            gameOver = true;
        }

        if(gameOver)
        {
            if(won)
            {
                textbox.text = "You Win!\nPress R to Restart!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to Restart!";
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }


    }
}
