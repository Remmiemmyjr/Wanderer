using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float moveSpeedDamp = 0.5f;
    Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);

    Vector3 Destination = Vector3.zero;




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
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y = moveSpeed * moveSpeedDamp;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y = moveSpeedDamp * -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = moveSpeedDamp * -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
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
    /* bool ValidDir(Vector2 direction)
     {
         //draw a line from the next tile over + a little and check if the maze is in the way
         Vector2 pos = transform.position;
         direction += direction * 0.55f;
         //bit shift the index of the layermask to only check layer 8
         //which should be the maze
         int layerMask = 1 << 8;
         RaycastHit2D hit = Physics2D.Linecast(pos + direction, pos, layerMask);
         return hit.collider == null;
     } */
}