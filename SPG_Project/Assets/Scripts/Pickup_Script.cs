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
    }
}
