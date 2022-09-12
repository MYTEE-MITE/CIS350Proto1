/*
 * John Green
 * Challenge 2
 * Allows for creation of dogs after cooldown
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool canPress = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canPress)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canPress = false;
            StartCoroutine("PressWait");
        }
    }

    IEnumerator PressWait()
    {
        yield return new WaitForSeconds(2f);
        canPress = true;
    }
}
