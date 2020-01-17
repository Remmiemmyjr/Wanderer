﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollection : MonoBehaviour
{
    public int Crystals = 1;
    public bool DestroyOnCollide = true;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.UpdateCounter(Crystals);
        if (DestroyOnCollide)
        {
            Destroy(gameObject);
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
