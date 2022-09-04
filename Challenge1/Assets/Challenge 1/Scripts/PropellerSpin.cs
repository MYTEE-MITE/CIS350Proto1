/*
 * John Green
 * Assignment 2 Challenge
 * adds propeller spinning animation
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }
}
