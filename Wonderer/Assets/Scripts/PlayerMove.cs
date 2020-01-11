using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float moveSpeedDamp = 0.5f; 
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
            velocity.y = moveSpeed * moveSpeedDamp;  
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            velocity.y = moveSpeedDamp * -moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            velocity.x = moveSpeedDamp * -moveSpeed; 
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            velocity.x = moveSpeed * moveSpeedDamp;
        }
        else
        {
            velocity.y = 0;
            velocity.x = 0;
        }

        transform.position += velocity;
    }
 
}
