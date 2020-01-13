using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float moveSpeed;
    Vector3 toPlayer = new Vector3(0.0f, 0.0f, 0.0f);
    Transform Player; 
    int maxDistance = 15;
    bool following = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        moveSpeed = Random.Range(0.01f, 0.06f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) <= maxDistance)
        {
            following = true;
        }
        if(following)
        {
            Follow();
        }
    }

    private void Follow()
    {

        toPlayer = Player.position - transform.position;
        if(System.Math.Abs(toPlayer.x) > System.Math.Abs(toPlayer.y))
        {
            toPlayer.y = Random.Range(-1, 1);
        }
        else
        {
            toPlayer.x = Random.Range(-1, 1);
        }

        toPlayer = toPlayer.normalized * moveSpeed;
        transform.position += toPlayer;
        

        //transform.position += velocity * moveSpeed;
    }
}
