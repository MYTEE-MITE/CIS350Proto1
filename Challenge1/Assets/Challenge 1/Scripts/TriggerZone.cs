/*
 * John Green
 * Assignment 2 Challenge
 * Trigger zones increment score once
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            ScoreManager.score++;
            triggered = true;
        }
    }
}
