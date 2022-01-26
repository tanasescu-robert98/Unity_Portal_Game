using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_Walls : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Move_Down = true;
    public bool Finished_Moving = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Stand_Script.Green_Orb_Picked == true)
        {
            if(Move_Down == true && Finished_Moving == false)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 3 * Time.deltaTime, transform.position.z);

                if(transform.position.y <= 20)
                {
                    Finished_Moving = false;
                }
            }
        }
    }
}
