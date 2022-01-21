using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Script : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 5 * Time.deltaTime);
        transform.position += transform.forward * 1;
    }
}
