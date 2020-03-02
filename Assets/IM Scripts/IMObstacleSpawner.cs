using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        

    }*/

    public Transform[] spawnPoints;
    public GameObject obstacle;
    private float timeToSpawn = 2f; //2 mp után spawnol
    public float timeBetweenWaves = 3f;
    public GameObject iMEndGameUI;
    public float destroyTime = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn && iMEndGameUI.activeInHierarchy == false)
        {
            SpawnObstacles();
            timeToSpawn = Time.time + timeBetweenWaves;
            timeBetweenWaves += 0.01f;
        }
    }

    void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(obstacle, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
