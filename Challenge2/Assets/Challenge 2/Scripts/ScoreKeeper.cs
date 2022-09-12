/*
 * John Green
 * Challenge 2
 * Keeps track of score and health
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text textbox;

    public int score = 0;
    public int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        //set text component reference on start
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0\nHealth: 5";
 
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score + "\nHealth: " + health;
    }
}
