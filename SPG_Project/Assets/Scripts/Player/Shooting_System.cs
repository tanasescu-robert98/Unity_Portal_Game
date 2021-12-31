using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_System : MonoBehaviour
{
    public ParticleSystem MuzzleFlash;
    public Camera fpsCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MuzzleFlash.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit Hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out Hit))
        {
            Debug.Log(Hit.transform.name);
            if(Hit.transform.gameObject.name.Contains("Enemy"))
                Hit.transform.gameObject.GetComponent<Enemy>().health -= 20;
        }
    }
}
