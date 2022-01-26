using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Quit_Game_Button_End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit_Button_Ending()
    {
        EditorApplication.isPlaying = false;
    }
}
