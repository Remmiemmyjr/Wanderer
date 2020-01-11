using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 4;
    Vector3 toPlayer = new Vector3(0.0f, 0.0f, 0.0f);
    Transform Player; 
    int maxDistance = 15;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) <= maxDistance)
        {
            Follow();
        }
    }

    private void Follow()
    {

        toPlayer = Player.position - transform.position;
        

        //transform.position += velocity * moveSpeed;
    }
}
