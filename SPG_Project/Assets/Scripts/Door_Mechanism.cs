using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Mechanism : MonoBehaviour
{
    public GameObject Door;
    private bool Open_Door = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Open_Door == true && Door.transform.name == "Door_Industrial_Pickup")
        {
            if (Door.transform.position.x >= 700)
            {
                Open_Door = false;
            }
            else
            {
                Door.transform.position = new Vector3(Door.transform.position.x + 3 * Time.deltaTime, Door.transform.position.y, Door.transform.position.z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Open_Door = true;
            Debug.Log("SAL");
        }
    }
}
