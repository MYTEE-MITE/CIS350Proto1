/*
 * John Green
 * Challenge 3
 * Allows for vertical player movement between 2 bounds. Also plays sounds and handles collsions between bombs and money.
 * Updates score accordingly.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;
    public bool isLowEnough = true;
    public bool canPlaySound = true;

    public float floatForce;
    public float upperBound = 14f;
    public float lowerBound = 3f;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;
    private ScoreManager scoreManager;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip boingSound;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();

        scoreManager = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreManager>();

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < upperBound)
        {
            isLowEnough = true;
        }
        else
        {
            isLowEnough = false;
        }

        if(transform.position.y <= lowerBound)
        {
            playerRb.AddForce(Vector3.up * floatForce);
            if(canPlaySound)
            {
                playerAudio.PlayOneShot(boingSound);
                canPlaySound = false;
                StartCoroutine("SoundCooldown");
            }
        }

        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && isLowEnough)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);
            scoreManager.score++;
        }

    }

    IEnumerator SoundCooldown()
    {
        yield return new WaitForSeconds(0.3f);
        canPlaySound = true;
    }

}
