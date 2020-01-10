using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);
   



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity.y = moveSpeed;
            print("Moving");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            velocity.y = -moveSpeed;
            print("Moving");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            velocity.x = -moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            velocity.x = moveSpeed;
        }
        else
        {
            velocity.y = 0;
            velocity.x = 0;
        }

        transform.position += velocity;
        
    }
 
}
