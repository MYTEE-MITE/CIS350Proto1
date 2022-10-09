/*
 * John Green
 * Assignment 5A
 * Keeps track of score.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public float score = 0;
    public GemCollect gemCollect;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<Text>();
        gemCollect = GameObject.FindGameObjectWithTag("Player").GetComponent<GemCollect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gemCollect.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        
    }
}
