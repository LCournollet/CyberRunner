using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public List<Transform> spawnPoints;

    public GameObject[] enemyPrefabs;
    public int enemyNumber = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyNumber; i++)
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Count);
            Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnPoints.Remove(spawnPoints[randSpawnPoint]);
        }
    }
}
