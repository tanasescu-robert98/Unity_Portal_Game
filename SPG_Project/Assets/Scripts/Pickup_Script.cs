using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource pickup_sound;
    void Start()
    {
        pickup_sound = pickup_sound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && gameObject.transform.name.Contains("Industrial"))
        {
            UIManager.Industrial_Collected_Pickups++;
            pickup_sound.Play();
            Destroy(gameObject);
        }

        if(other.tag == "Player" && gameObject.transform.name.Contains("Red_Orb"))
        {
            pickup_sound.Play();
            Stand_Script.Red_Orb_Picked = true;
            Destroy(gameObject);
        }

        if (other.tag == "Player" && gameObject.transform.name.Contains("Blue_Orb"))
        {
            pickup_sound.Play();
            Stand_Script.Blue_Orb_Picked = true;
            Destroy(gameObject);
        }

        if (other.tag == "Player" && gameObject.transform.name.Contains("Green_Orb"))
        {
            pickup_sound.Play();
            Stand_Script.Green_Orb_Picked = true;
            Destroy(gameObject);
        }
    }
}
