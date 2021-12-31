using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health;
    public float maxhealth;

    public GameObject HealthBarUI;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        slider.value = CalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateHealth();

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if (health > maxhealth)
        {
            health = maxhealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxhealth;
    }
}
