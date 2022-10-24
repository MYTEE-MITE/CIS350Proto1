/*
 * John Green
 * Assignment 5B
 * Displays win text upon successful completion of level
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    public Text winText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            winText.text = "You Win!";
        }
    }
}
