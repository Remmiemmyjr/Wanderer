using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    int minEnemies = 2;
    int maxEnemies = 4;
    Rect SpawnArea = new Rect(-30f, -23f, 45f, 45f);
    public GameObject EnemyTemplate;

    // Start is called before the first frame update
    void Start()
    {
        //Only for testing purposes
        StartNewLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartNewLevel()
    {
        int enemiesToSpawn = (int)Random.Range(minEnemies, maxEnemies + 0.99f);

        for (int i = 1; i <= enemiesToSpawn; i++)
        {
            float x = Random.Range(SpawnArea.xMin, SpawnArea.xMax);
            float y = Random.Range(SpawnArea.yMin, SpawnArea.yMax);
            Vector3 spawnPos = new Vector3(x, y);
         
            GameObject clone = Instantiate(EnemyTemplate, spawnPos, Quaternion.identity);

        }
    }
}
