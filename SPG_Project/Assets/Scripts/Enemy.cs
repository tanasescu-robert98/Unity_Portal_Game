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
    public ParticleSystem Explosion;
    public LayerMask Mask_for_see;
    public AudioSource explosion_sound;

    float timer = 0.0f;

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
        float seconds = timer % 60;

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

        //if(Input.GetKeyDown(KeyCode.J))
        if(seconds > 3 & Player_has_been_seen == true)
        {
            Instantiate(Projectile, transform.position, transform.rotation);
            timer = 0.0f;
        }

        
           
        if (health <= 0)
        {
            explosion_sound.Play();
            Instantiate(Explosion, transform.position, transform.rotation);
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
