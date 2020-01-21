using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollection : MonoBehaviour
{
    public int Crystals = 1;
    public bool DestroyOnCollide = true;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            Health.UpdateCounter(Crystals);
            Destroy(this.gameObject);
            
            if(Health.crystalCounter == CrystalSpawn.numOfCrystals)
            {
                var gate = GameObject.Find("Gate");
                Destroy(gate);
                Health.crystalCounter = 0;
            }
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
