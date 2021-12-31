using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public GameObject crosshair_canvas;
    private bool crosshair_status = true;
    // Start is called before the first frame update
    void Start()
    {
        crosshair_canvas.SetActive(crosshair_status);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (crosshair_status == true)
                crosshair_status = false;
            else
                crosshair_status = true;
        }
        crosshair_canvas.SetActive(crosshair_status);
    }
}
