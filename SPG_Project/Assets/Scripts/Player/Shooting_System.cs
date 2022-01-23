using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_System : MonoBehaviour
{
    public ParticleSystem MuzzleFlash;
    public Camera fpsCam;
    public AudioSource gun_sound;
    public GameObject UI_Screen;
    // Start is called before the first frame update
    void Start()
    {
        gun_sound = gun_sound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UI_Screen.activeSelf)
        {
            // do nothing
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                MuzzleFlash.Play();
                Shoot();
            }
        }
    }

    void Shoot()
    { 
        RaycastHit Hit;

        if(Main_Menu.Audio_Enabled == true)
            gun_sound.Play();

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out Hit))
        {
            if (Hit.transform.gameObject.name.Contains("Enemy"))
                Hit.transform.gameObject.GetComponent<Enemy>().health -= 20;
        }
    }
}
