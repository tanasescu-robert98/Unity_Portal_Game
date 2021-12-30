using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public CharacterController controller;

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

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TEST");
        if (other.tag == "Portal_Tag")
        {
            Debug.Log("TES2T");
            if (other.gameObject.name == "Portal_Trigger")
            {
                controller.enabled = false;
                controller.transform.position = new Vector3(6, 1, 210);
                controller.enabled = true;
            }
            else if(other.gameObject.name == "Portal_Trigger_2")
            {
                controller.enabled = false;
                controller.transform.position = new Vector3(6, 1, 21);
                //controller.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
                controller.enabled = true;
            }
        }
    }
}
