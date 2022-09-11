using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    public float leftLimit = -30f;
    public float bottomLimit = -5f;

    public ScoreKeeper scoreKeeperScript;

    private void Start()
    {
        scoreKeeperScript = GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            scoreKeeperScript.health--;
            Destroy(gameObject);
        }

    }
}
