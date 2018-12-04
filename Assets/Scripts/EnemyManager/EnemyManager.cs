using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 5.0f;
    public Transform[] spawnPoints;
    public float decreaseRate = 0.5f;

    // Use this for initialization
    void Start()
    {
        //InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
        Invoke("SpawnEnemy", spawnTime);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        if (spawnTime > 0.5f) {
            spawnTime -= decreaseRate;
        }

        Invoke("SpawnEnemy", spawnTime);
    }
}
