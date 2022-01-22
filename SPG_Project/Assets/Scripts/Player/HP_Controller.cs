using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int currentHealth = 100;

    public Player_HP healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Projectile"))
        {
            if(other.name.Contains("Black"))
                currentHealth = currentHealth - 100;
            else
                currentHealth = currentHealth - 10;
            healthBar.SetHealth(currentHealth);
        }   
    }
}
