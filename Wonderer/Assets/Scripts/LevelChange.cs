using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = 5; 
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (this.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Level2");
        }
        
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (this.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Level2");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
            Destroy(gameObject);
    }

}
