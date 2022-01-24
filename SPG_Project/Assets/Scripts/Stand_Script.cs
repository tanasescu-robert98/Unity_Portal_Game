using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stand_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Red_Orb;
    public GameObject Blue_Orb;
    public GameObject Green_Orb;
    public GameObject Door_To_Final_Place;

    public static bool Red_Orb_Picked = false;
    public static bool Blue_Orb_Picked = false;
    public static bool Green_Orb_Picked = false;

    public static bool is_Red_Orb_Placed = false;
    public static bool is_Green_Orb_Placed = false;
    public static bool is_Blue_Orb_Placed = false;

    public bool MoveUp = false;
    void Start()
    {
        Red_Orb.gameObject.SetActive(false);
        Blue_Orb.gameObject.SetActive(false);
        Green_Orb.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(is_Red_Orb_Placed == true && is_Blue_Orb_Placed == true && is_Green_Orb_Placed == true && Door_To_Final_Place.transform.position.y < 24)
        {
            MoveUp = true;
        }

        if (MoveUp == true)
        {
            Door_To_Final_Place.transform.position = new Vector3(Door_To_Final_Place.transform.position.x, Door_To_Final_Place.transform.position.y + 2 * Time.deltaTime, Door_To_Final_Place.transform.position.z);
        }

        if (Door_To_Final_Place.transform.position.y >= 25)
            MoveUp = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && gameObject.transform.name.Contains("Red"))
        {
            if (Red_Orb_Picked)
            {
                Red_Orb.gameObject.SetActive(true);
                is_Red_Orb_Placed = true;
            }
        }
        if (other.tag == "Player" && gameObject.transform.name.Contains("Blue"))
        {
            if (Blue_Orb_Picked)
            {
                Blue_Orb.gameObject.SetActive(true);
                is_Blue_Orb_Placed = true;
            }
        }
        if (other.tag == "Player" && gameObject.transform.name.Contains("Green"))
        {
            if (Green_Orb_Picked)
            {
                Green_Orb.gameObject.SetActive(true);
                is_Green_Orb_Placed = true;
            }
        }
    }
}
