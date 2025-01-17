﻿/*
 * John Green
 * Assignment 2
 * Trigger zone increments score once
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAdd : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
