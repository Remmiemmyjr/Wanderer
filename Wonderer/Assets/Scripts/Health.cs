using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int healthCounter = 3;
    public static int crystalCounter = 0;
    private static TextMesh crystalCount;
    private static TextMesh HealthBar;

    public bool DestroyOnCollide = true;

    // Start is called before the first frame update
    void Start()
    {
        crystalCount = GameObject.Find("crystalCount").GetComponent<TextMesh>();
        HealthBar = GameObject.Find("healthCounter").GetComponent<TextMesh>();
        HealthBar.text = healthCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void UpdateCounter(int Collected)
    {
        crystalCounter += Collected;
        crystalCount.text = crystalCounter.ToString();
    }
    public static void UpdateHealthCounter(int healthChange)
    {

        healthCounter -= healthChange;
        HealthBar.text = healthCounter.ToString();
        //if health = 0 change scene to end scene
        if (healthCounter == 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}