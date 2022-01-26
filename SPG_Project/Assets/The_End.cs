using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class The_End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EditorApplication.isPlaying = false;
        }
    }
}
