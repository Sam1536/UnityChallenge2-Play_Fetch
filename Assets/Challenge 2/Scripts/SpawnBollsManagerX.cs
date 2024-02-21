using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBollsManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -35f;
    private float spawnLimitXRight = 7f;
    
    private float spawnPosY = 30;



    private float startDelay = .3f;
    private float spawnInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }    

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int index = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight),spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }

   

}
