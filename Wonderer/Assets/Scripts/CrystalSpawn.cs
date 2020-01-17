using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawn : MonoBehaviour
{
    int numOfCrystals = 6;
    Rect SpawnArea = new Rect(-30f, -23f, 50f, 45f);
    public GameObject CrystalTemplate;

    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void Spawner()
    {
        for (int i = 1; i <= numOfCrystals; i++)
        {
            float x = Random.Range(SpawnArea.xMin, SpawnArea.xMax);
            float y = Random.Range(SpawnArea.yMin, SpawnArea.yMax);
            Vector3 spawnPos = new Vector3(x, y);

            GameObject clone = Instantiate(CrystalTemplate, spawnPos, Quaternion.identity);
        }
    }
}
