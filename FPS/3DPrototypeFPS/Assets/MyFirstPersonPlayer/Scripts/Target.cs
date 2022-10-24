/*
 * John Green
 * Assignment 5B
 * If raycast collides with an object, health is taken away. Destroys "dead" gameobjects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();    
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
