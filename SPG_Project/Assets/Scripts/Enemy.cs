using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float health;
    public float maxhealth;

    public GameObject HealthBarUI;
    public Slider slider;

    public GameObject Player;
    public GameObject Projectile;
    public GameObject Projectile_Black;
    public GameObject Projectile_Smoke;
    public ParticleSystem Explosion;
    public LayerMask Mask_for_see;
    public AudioSource explosion_sound;

    private float timer = 0.0f;

    private float timer_rapid_fire = 0.0f;

    private float timer_green = 0.0f;

    private bool Player_has_been_seen = false;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        slider.value = CalculateHealth();
        explosion_sound = explosion_sound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer_rapid_fire += Time.deltaTime;
        timer_green += Time.deltaTime; 
        float seconds = timer % 60;
        float seconds_rapid_fire = timer_rapid_fire % 60;
        float seconds_green = timer_green % 60;

        float distance_to_player = Vector3.Distance(Player.transform.position, transform.position);

        RaycastHit hit;


        slider.value = CalculateHealth();

        if(distance_to_player < 100)
        {
            
            if (Physics.Linecast(transform.position, Player.transform.position, out hit, Mask_for_see))
            {
                // do nothing
                Player_has_been_seen = false;
            }
            else
            {
                transform.LookAt(Player.transform);
                Player_has_been_seen = true;
            }
            
        }
        else if(distance_to_player > 100)
        {
            Player_has_been_seen = false;
        }

        if (seconds > 1 && Player_has_been_seen == true)
        {
            if (transform.name.Contains("Black"))
            {
                Instantiate(Projectile_Black, transform.position, transform.rotation);
                Instantiate(Projectile_Smoke, transform.position, transform.rotation);
            }
            else if (transform.name.Contains("Red"))
            { 
                Instantiate(Projectile, transform.position, transform.rotation);
                Instantiate(Projectile_Smoke, transform.position, transform.rotation);
            }
            else if (transform.name.Contains("Blue"))
            {
                Instantiate(Projectile, transform.position, transform.rotation);
                Instantiate(Projectile_Smoke, transform.position, transform.rotation);
            }
            timer = 0.0f;
        }

        if (seconds_rapid_fire > 0.25f && Player_has_been_seen == true)
        {
            if(transform.name.Contains("Yellow"))
            {
                Instantiate(Projectile, transform.position, transform.rotation);
            }
            timer_rapid_fire = 0.0f;
        }

        if(seconds_green > 0.75f && Player_has_been_seen == true)
        {
            if (transform.name.Contains("Green"))
            {

                if (transform.forward.x > 0 && transform.forward.z > 0)
                {
                    //Debug.Log("SAL1");
                    Instantiate(Projectile, transform.position + new Vector3(0, 0, 2), transform.rotation);
                    Instantiate(Projectile, transform.position, transform.rotation);
                    Instantiate(Projectile, transform.position + new Vector3(0, 0, -2), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(0, 0, 2), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position, transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(0, 0, -2), transform.rotation);
                }
                else if (transform.forward.z < 0 && transform.forward.x < 0)
                {
                    //Debug.Log("SAL2");
                    Instantiate(Projectile, transform.position + new Vector3(2, 0, 0), transform.rotation);
                    Instantiate(Projectile, transform.position, transform.rotation);
                    Instantiate(Projectile, transform.position + new Vector3(-2, 0, 0), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(2, 0, 0), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position, transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(-2, 0, 0), transform.rotation);
                }
                else if (transform.forward.z > 0 && transform.forward.x < 0)
                {
                    //Debug.Log("SAL3");
                    Instantiate(Projectile, transform.position + new Vector3(2, 0, 0), transform.rotation);
                    Instantiate(Projectile, transform.position, transform.rotation);
                    Instantiate(Projectile, transform.position + new Vector3(-2, 0, 0), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(2, 0, 0), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position, transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(-2, 0, 0), transform.rotation);
                }
                else if (transform.forward.z < 0 && transform.forward.x > 0)
                {
                    //Debug.Log("SAL4");
                    Instantiate(Projectile, transform.position + new Vector3(0, 0, 2), transform.rotation);
                    Instantiate(Projectile, transform.position, transform.rotation);
                    Instantiate(Projectile, transform.position + new Vector3(0, 0, -2), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(0, 0, 2), transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position, transform.rotation);
                    Instantiate(Projectile_Smoke, transform.position + new Vector3(0, 0, -2), transform.rotation);
                }
            }
            timer_green = 0.0f;
        }


        if (health <= 0)
        {
            if(Main_Menu.Audio_Enabled == true)
                explosion_sound.Play();

            Instantiate(Explosion, transform.position, transform.rotation);
            if(transform.name.Contains("Blue"))
                Destroy(gameObject.GetComponent<Enemy_Blue_Move_Script>().particle_system);
            Destroy(gameObject);
        }

        if (health > maxhealth)
        {
            health = maxhealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxhealth;
    }
}
