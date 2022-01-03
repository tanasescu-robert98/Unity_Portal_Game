using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static bool isPlayerinSpawnRoom;
    public static bool isPlayerinIndustrial;
    public static bool isPlayerinLake;
    public static bool isPlayerinVillage;

    public TMP_Text UI_Text_Location;
    public GameObject Black_Screen;
    // Start is called before the first frame update
    void Start()
    {
        isPlayerinSpawnRoom = true;
        isPlayerinIndustrial = false;
        isPlayerinLake = false;
        isPlayerinVillage = false;
        Black_Screen.SetActive(false);
        UI_Text_Location.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Black_Screen.SetActive(true);
            //UI_Text_Location.text = "Industrial Area";
            UI_Text_Location.gameObject.SetActive(true);
        }
        else if(Input.GetKeyUp(KeyCode.Tab))
        {
            Black_Screen.SetActive(false);
            UI_Text_Location.gameObject.SetActive(false);
        }

        if(isPlayerinIndustrial)
        {
            UI_Text_Location.text = "Industrial Area";
        }
        else if(isPlayerinLake)
        {
            UI_Text_Location.text = "Lake Area";
        }
        else if(isPlayerinVillage)
        {
            UI_Text_Location.text = "Village Area";
        }
        else if(isPlayerinSpawnRoom)
        {
            UI_Text_Location.text = "Spawn Room";
        }
    }
}
