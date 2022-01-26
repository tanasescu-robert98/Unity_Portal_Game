using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Finished_Game_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Canvas_Main_Menu;
    public GameObject Canvas_Tab_Menu;
    public GameObject Canvas_Finished_Menu;
    public GameObject Player;
    public Camera Player_Camera;
    public Camera Main_Menu_Camera;
    public Camera Finished_Game_Camera;

    public static bool is_Game_Finished = false;

    void Start()
    {
        Canvas_Finished_Menu.SetActive(false);
        Finished_Game_Camera.enabled = false;
}

    // Update is called once per frame
    void Update()
    {
        if(is_Game_Finished == true)
        {
            Player_Camera.enabled = false;
            Main_Menu_Camera.enabled = false;
            Finished_Game_Camera.enabled = true;
            Canvas_Main_Menu.gameObject.SetActive(false);
            Canvas_Tab_Menu.gameObject.SetActive(false);
            Canvas_Finished_Menu.gameObject.SetActive(true);
            Player.gameObject.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            is_Game_Finished = true;
            //EditorApplication.isPlaying = false;
        }
    }
}
