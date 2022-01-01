using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_TeleportScript : MonoBehaviour
{
    public Transform player;
    public CharacterController player_controller;
    public Transform receiver;
    private bool playerIsOVerLapping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            player.position = new Vector3(100, 100, 100);
        }
        
        if (playerIsOVerLapping)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
             //   Debug.Log("PLM1");
           // Debug.Log(dotProduct);


            if (dotProduct < 0f)
            {
                Debug.Log("PLM");

                player_controller.enabled = false;

                float rotationDiff = -Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Debug.Log(player.position);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = receiver.position + positionOffset;

                Debug.Log("PLM2");
                Debug.Log(receiver.position);

                player_controller.enabled = true;

                playerIsOVerLapping = false;

            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("SAL");
            playerIsOVerLapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("SAL2");

            playerIsOVerLapping = false;
        }
    }
}
