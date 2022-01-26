using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Blue_Move_Script : MonoBehaviour
{
    // Start is called before the first frame update
    private bool moveLeft = false;
    private bool moveRight = true;

    private float maximum_right;
    private float maximum_left;

    public GameObject particle_system;
    void Start()
    {
        maximum_right = transform.position.x + 50;
        maximum_left = transform.position.x - 50;
    }

    // Update is called once per frame
    void Update()
    {
        particle_system.transform.position = transform.position;
        if (moveRight)
        {
            transform.position = new Vector3(transform.position.x + 8 * Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x > maximum_right)
                moveRight = false;
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 8 * Time.deltaTime, transform.position.y, transform.position.z);
            if (transform.position.x < maximum_left)
                moveRight = true;
        }
    }
}
