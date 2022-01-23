using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public GameObject Canvas_Main_Menu;
    public GameObject Canvas_Tab_Menu;
    public Camera Player_Camera;
    public Camera Main_Menu_Camera;
    public GameObject Gun_Sound_Manager;
    public GameObject Player;
    public static bool Audio_Enabled = true;
    public TMP_Text audio_button_text;
    public static bool Game_Started = false;
    // Start is called before the first frame update
    void Start()
    {
        Player_Camera.enabled = false;
        Main_Menu_Camera.enabled = true;
        Canvas_Main_Menu.SetActive(true);
        Canvas_Tab_Menu.SetActive(false);
        Gun_Sound_Manager.SetActive(false);
        Player.SetActive(false);
        Cursor.visible = true;
    }

    public void Start_Button()
    {
        Player_Camera.enabled = true;
        Main_Menu_Camera.enabled = false;
        Canvas_Main_Menu.SetActive(false);
        Canvas_Tab_Menu.SetActive(true);
        Gun_Sound_Manager.SetActive(true);
        Player.SetActive(true);
        Cursor.visible = false;
        Game_Started = true;
    }

    public void Audio_Button()
    {
        if(Audio_Enabled == true)
        {
            audio_button_text.text = "Audio Off";
            Audio_Enabled = false;
        }
        else
        {
            audio_button_text.text = "Audio On";
            Audio_Enabled = true;
        }
    }

    public void Quit_Button()
    {
        EditorApplication.isPlaying = false;
    }
}
