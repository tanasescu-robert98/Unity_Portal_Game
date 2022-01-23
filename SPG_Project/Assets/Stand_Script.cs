using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stand_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Red_Orb;
    public GameObject Blue_Orb;
    public GameObject Green_Orb;
    void Start()
    {
        Red_Orb.gameObject.SetActive(false);
        Blue_Orb.gameObject.SetActive(false);
        Green_Orb.gameObject.SetActive(false);
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && gameObject.transform.name.Contains("Red"))
        {
            Red_Orb.gameObject.SetActive(true);
        }
        if (other.tag == "Player" && gameObject.transform.name.Contains("Blue"))
        {
            Blue_Orb.gameObject.SetActive(true);
        }
        if (other.tag == "Player" && gameObject.transform.name.Contains("Green"))
        {
            Green_Orb.gameObject.SetActive(true);
        }
    }
}
