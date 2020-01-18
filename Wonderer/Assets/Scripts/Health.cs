using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int healthCounter = 3;
    public static int Counter = 0;
    private static TextMesh crystalCount;
    private static TextMesh HealthBar;

    public bool DestroyOnCollide = true;
    
    // Start is called before the first frame update
    void Start()
    {
        crystalCount = GameObject.Find("crystalCount").GetComponent<TextMesh>();
        HealthBar = GameObject.Find("HealthBar").GetComponent<TextMesh>();
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
    public void UpdateHealthCounter(int healthChange)
    {
        if (DestroyOnCollide)
        {
            Destroy(gameObject);
        }
        else
        {
            healthCounter -= healthChange;
            HealthBar.text = healthCounter.ToString();
            //if health = 0 change scene to end scene
            if(healthCounter == 0)
            {
                SceneManager.LoadScene("End");
            }
        }
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