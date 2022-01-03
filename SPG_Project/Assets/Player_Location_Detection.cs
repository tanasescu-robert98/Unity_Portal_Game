using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Location_Detection : MonoBehaviour
{
    // Start is called before the first frame update
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
                    break;
                case "Lake_Trigger":
                    UIManager.isPlayerinIndustrial = false;
                    UIManager.isPlayerinLake = true;
                    UIManager.isPlayerinVillage = false;
                    UIManager.isPlayerinSpawnRoom = false;
                    break;
                case "Village_Trigger":
                    UIManager.isPlayerinIndustrial = false;
                    UIManager.isPlayerinLake = false;
                    UIManager.isPlayerinVillage = true;
                    UIManager.isPlayerinSpawnRoom = false;
                    break;
            }
        }
    }
}
