using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_System : MonoBehaviour
{
    public ParticleSystem MuzzleFlash;
    public Camera fpsCam;
    public AudioSource gun_sound;
    public GameObject UI_Screen;
    public GameObject Projectile;
    public GameObject Projectile_Smoke;
    public static int Kill_Count = 0;
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
            else if(Input.GetMouseButtonDown(1) && Kill_Count >= 3)
            {
                Kill_Count = 0;
                Alternate_Shoot();
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

    void Alternate_Shoot()
    {
        var projectile = Instantiate(Projectile, fpsCam.transform.position + fpsCam.transform.forward * 5, fpsCam.transform.rotation);
        Instantiate(Projectile_Smoke, fpsCam.transform.position + fpsCam.transform.forward * 5, fpsCam.transform.rotation);
    }
}
