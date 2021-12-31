using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public CharacterController controller;

    public GameObject Vrum_Vrum;

    public GameObject Portal_SpawnArea1;
    public GameObject Portal_SpawnArea2;
    public GameObject Portal_SpawnArea3;
    public GameObject Portal_World1;
    public GameObject Portal_World2;
    public GameObject Portal_World3;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25;
            controller.Move(move * speed * Time.deltaTime);
        }
        else
        {
            speed = 12;
            controller.Move(move * speed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        if (Input.GetButton("Jump") && !isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            Vrum_Vrum.gameObject.transform.position = controller.transform.position;
        }
        if (Input.GetKey(KeyCode.C) && !isGrounded)
        {
            velocity.y = -Mathf.Sqrt(jumpHeight * -12f * gravity);
        }


        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal_Tag")
        {
            if (other.gameObject.name == "Portal_Trigger_SpawnArea1")
            {
                controller.enabled = false;
                controller.transform.position = Portal_World1.transform.position + new Vector3(4, 0, 3);
                controller.enabled = true;
            }
            else if (other.gameObject.name == "Portal_Trigger_SpawnArea2")
            {
                controller.enabled = false;
                controller.transform.position = Portal_World2.transform.position + new Vector3(4, 0, 3);
                controller.enabled = true;
            }
            else if (other.gameObject.name == "Portal_Trigger_SpawnArea3")
            {
                controller.enabled = false;
                controller.transform.position = Portal_World3.transform.position + new Vector3(4, 0, 3);
                controller.enabled = true;
            }
            else if(other.gameObject.name == "Portal_Trigger_World1")
            {
                controller.enabled = false;
                controller.transform.position = Portal_SpawnArea1.transform.position - new Vector3(-4, 0, 4);
                controller.enabled = true;
            }
            else if (other.gameObject.name == "Portal_Trigger_World2")
            {
                controller.enabled = false;
                controller.transform.position = Portal_SpawnArea2.transform.position - new Vector3(-4, 0, 4);
                controller.enabled = true;
            }
            else if (other.gameObject.name == "Portal_Trigger_World3")
            {
                controller.enabled = false;
                controller.transform.position = Portal_SpawnArea3.transform.position - new Vector3(-4, 0, 4);
                controller.enabled = true;
            }
        }
    }
}
