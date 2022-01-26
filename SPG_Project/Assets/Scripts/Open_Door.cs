using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public GameObject Door;
    private bool MoveUp = false;
    private bool MoveDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveUp)
        {
            if (Door.transform.position.y >= 30)
            {
                MoveUp = false;
            }
            else
            {
                Door.transform.position = new Vector3(Door.transform.position.x, Door.transform.position.y + 3 * Time.deltaTime, Door.transform.position.z);
            }
        }
        else if(MoveDown)
        {
            if (Door.transform.position.y <= 18)
            {
                MoveDown = false;
            }
            else
            {
                Door.transform.position = new Vector3(Door.transform.position.x, Door.transform.position.y - 3 * Time.deltaTime, Door.transform.position.z);
            }
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            MoveUp = true;
            MoveDown = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            MoveDown = true;
            MoveUp = false;
        }
    }
}
