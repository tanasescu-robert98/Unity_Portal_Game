using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Location_Detection : MonoBehaviour
{
    // Start is called before the first frame update

    public Player_HP healthBar;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            switch(transform.name)
            {
                case "Industrial_Trigger":
                    UIManager.isPlayerinIndustrial = true;
                    UIManager.isPlayerinLake = false;
                    UIManager.isPlayerinVillage = false;
                    UIManager.isPlayerinSpawnRoom = false;
                    UIManager.Hint1_show = false;
                    UIManager.Hint2_show = false;
                    UIManager.Hint3_show = false;
                    UIManager.Hint4_show = false;
                    UIManager.Hint5_show = false;
                    UIManager.Hint6_show = false;
                    Character_Movement.Jetpack_Equiped = false;
                    break;
                case "Lake_Trigger":
                    UIManager.isPlayerinIndustrial = false;
                    UIManager.isPlayerinLake = true;
                    UIManager.isPlayerinVillage = false;
                    UIManager.isPlayerinSpawnRoom = false;
                    UIManager.Hint1_show = false;
                    UIManager.Hint2_show = false;
                    UIManager.Hint3_show = false;
                    UIManager.Hint4_show = false;
                    UIManager.Hint5_show = false;
                    UIManager.Hint6_show = false;
                    Character_Movement.Jetpack_Equiped = false;
                    break;
                case "Village_Trigger":
                    UIManager.isPlayerinIndustrial = false;
                    UIManager.isPlayerinLake = false;
                    UIManager.isPlayerinVillage = true;
                    UIManager.isPlayerinSpawnRoom = false;
                    UIManager.Hint1_show = false;
                    UIManager.Hint2_show = false;
                    UIManager.Hint3_show = false;
                    UIManager.Hint4_show = false;
                    UIManager.Hint5_show = false;
                    UIManager.Hint6_show = false;
                    Character_Movement.Jetpack_Equiped = false;
                    break;
                case "Spawn_Trigger":
                    UIManager.isPlayerinIndustrial = false;
                    UIManager.isPlayerinLake = false;
                    UIManager.isPlayerinVillage = false;
                    UIManager.isPlayerinSpawnRoom = true;
                    UIManager.Hint1_show = false;
                    UIManager.Hint2_show = false;
                    UIManager.Hint3_show = false;
                    UIManager.Hint4_show = false;
                    UIManager.Hint5_show = false;
                    UIManager.Hint6_show = false;
                    Character_Movement.Jetpack_Equiped = false;
                    HP_Controller.currentHealth = 100;
                    healthBar.SetHealth(HP_Controller.currentHealth);
                    break;
            }
        }
    }
}
