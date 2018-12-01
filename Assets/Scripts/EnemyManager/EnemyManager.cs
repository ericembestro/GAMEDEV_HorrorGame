using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform parent;
    public float spawnTime = 5.0f;
    public const string ON_SPAWN_ENEMY = "SPAWN_ENEMY";
    [SerializeField] private List<GameObject> enemiesSpawned = new List<GameObject>();
    public Transform goal;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        GameObject spawn = GameObject.Instantiate(this.enemy, this.parent);
        spawn.SetActive(true);

        Vector3 position = this.enemy.transform.localPosition;
        position.x = Random.Range(-4f, 4f);
        position.z = Random.Range(-4f, 4f);

        spawn.transform.localPosition = position;

        spawn.transform.LookAt(Camera.main.transform);

        enemiesSpawned.Add(spawn);

        
    }
}
