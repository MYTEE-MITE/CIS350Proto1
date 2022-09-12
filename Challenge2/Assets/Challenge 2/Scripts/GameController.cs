/*
 * John Green
 * Challenge 2
 * Handles win and lose conditions based off of score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool gameOver = false;
    public ScoreKeeper scoreKeeper;
    public SpawnManagerX spawnManager;

    void Start()
    {
        scoreKeeper = GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<ScoreKeeper>();
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreKeeper.score >= 5)
        {
            scoreKeeper.textbox.text = "You Win!\nPress R to Restart";
            gameOver = true;
        }

        if(scoreKeeper.health <= 0) 
        {
            scoreKeeper.textbox.text = "You lose.\nPress R to Restart";
            gameOver = true;
        }

        if(gameOver)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
