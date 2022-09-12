/*
 * John Green
 * Challenge 2
 * Increments score upon successful collision
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DetectCollisionsX : MonoBehaviour
{
    public ScoreKeeper scoreKeeperScript;

    private void Start()
    {
        scoreKeeperScript = GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<ScoreKeeper>();
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreKeeperScript.score++;
        Destroy(gameObject);
    }
}
