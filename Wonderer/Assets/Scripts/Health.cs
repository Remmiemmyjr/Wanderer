using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int healthBar = 3;
    public static int Counter = 0;
    private static TextMesh crystalCount;
    
    public bool DestroyOnCollide = true;
    // Start is called before the first frame update
    void Start()
    {
        crystalCount = GameObject.Find("crystalCount").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void UpdateCounter(int Collected)
    {
        Counter += Collected;
        crystalCount.text = Counter.ToString();
    }
  /*  private void OnTriggerEnter2D(Collider2D other)
    {
        UpdateCounter(amount);
        if (DestroyOnCollide)
        {
            Destroy(gameObject);
        }

    } */
}