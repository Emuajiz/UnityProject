using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawn : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject healthPrefab;
    Transform PlayerTransform;

    float randX, randY;
    public float xSafeZone = 2, ySafeZone = 2;
    Vector2 whereToSpawn;
    public float enemySpawnRate = 2f;
    public float healthSpawnRate = 4f;
    float countdown = 0.0f;

    public static int enemySpawned = 0;
    public int maxEnemySpawned = 10;
    public static int healthSpawned = 0;
    public int maxHealthSpawned = 5;

    void Start() {
        PlayerTransform = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        // Debug.Log(enemySpawned);
        if (countdown <= 0.0f)
        {
            if (enemySpawned < maxEnemySpawned)
                EnemySpawn();
            int randomSpawn = ((int)Random.Range(0f, 10f)) + 1;
            // Debug.Log(randomSpawn);
            if (randomSpawn > 9 && healthSpawned < maxHealthSpawned)
            {
                HealthSpawn();
            }
            countdown = enemySpawnRate;
        }
        countdown -= Time.deltaTime;
    }

    void spawnPosRandom(Vector2 pos2d)
    {
        Vector3 pos = PlayerTransform.position;

        randX = (int)Random.Range(-5f, 5f) * 2;
        randY = (int)Random.Range(-5f, 5f) * 2;

        while ((randX > pos.x - xSafeZone && randX < pos.x + xSafeZone) || (randY > pos.y - ySafeZone && randY < pos.y + ySafeZone))
        {
            randX = (int)Random.Range(-5f, 5f) * 2;
            randY = (int)Random.Range(-5f, 5f) * 2;
        }

        pos2d = new Vector2(randX, randY);

        // return posReady;
    }

    void EnemySpawn()
    {
        Vector3 pos = PlayerTransform.position;

        // Debug.Log(pos);

        randX = (int)Random.Range(-5f, 5f) * 2;
        randY = (int)Random.Range(-5f, 5f) * 2;

        while ((randX > pos.x - xSafeZone && randX < pos.x + xSafeZone) || (randY > pos.y - ySafeZone && randY < pos.y + ySafeZone))
        {
            randX = (int)Random.Range(-5f, 5f) * 2;
            randY = (int)Random.Range(-5f, 5f) * 2;
        }

        whereToSpawn = new Vector2(randX, randY);
        // whereToSpawn = spawnPosRandom;
        // spawnPosRandom(whereToSpawn);
        int random = (int)Random.Range(0, 10);
        if (random == 9)
        {
            Instantiate(enemyPrefab2, whereToSpawn, Quaternion.identity);
        }
        else if (random > 6)
        {
            Instantiate(enemyPrefab3, whereToSpawn, Quaternion.identity);
        }
        else
        {
            Instantiate(enemyPrefab, whereToSpawn, Quaternion.identity);
        }
        enemySpawned++;
    }
    void HealthSpawn()
    {
        randX = (int)Random.Range(-5f, 5f) * 2;
        randY = (int)Random.Range(-5f, 5f) * 2;
        whereToSpawn = new Vector2(randX, randY);
        Instantiate(healthPrefab, whereToSpawn, Quaternion.identity);
        healthSpawned++;
    }
}
