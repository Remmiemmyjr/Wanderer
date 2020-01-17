using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    int maxObstacle = 4;
    int minObstacle = 7; 
    Rect SpawnArea = new Rect(-30f, -23f, 55f, 45f);
    public GameObject ObstacleTemplate;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleSpawner();
    }

    // Update is called once per frame
    void ObstacleSpawner()
    {
        int obstaclesToSpawn = (int)Random.Range(minObstacle, maxObstacle + 0.99f);

        for (int i = 1; i <= obstaclesToSpawn; i++)
        {
            float x = Random.Range(SpawnArea.xMin, SpawnArea.xMax);
            float y = Random.Range(SpawnArea.yMin, SpawnArea.yMax);
            Vector3 spawnPos = new Vector3(x, y);

            GameObject clone = Instantiate(ObstacleTemplate, spawnPos, Quaternion.identity);

        }
    }
}
