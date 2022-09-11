using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;

    private int randomBall;

    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        StartCoroutine("SpawnBalls");
    }

    IEnumerator SpawnBalls()
    {
        yield return new WaitForSeconds(startDelay);

        while (!gameController.gameOver)
        {
            SpawnRandomBall();

            float randomDelay = Random.Range(3f, 5f);

            yield return new WaitForSeconds(randomDelay);
        }
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        randomBall = Random.Range(0, 3);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
    }

}
