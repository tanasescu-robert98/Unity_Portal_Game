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
    public Image Hint1;
    public Image Hint2;
    public Image Hint3;

    public Sprite Blur;
    public Sprite Hint1_Industrial;
    public Sprite Hint2_Industrial;
    public Sprite Hint3_Industrial;
    public static bool Hint1_show = false;
    public static bool Hint2_show = false;
    public static bool Hint3_show = false;
    //public Sprite Hint2_Industrial;
    //public Sprite Hint3_Industrial;
    // Start is called before the first frame update
    void Start()
    {
        isPlayerinSpawnRoom = true;
        isPlayerinIndustrial = false;
        isPlayerinLake = false;
        isPlayerinVillage = false;
        Black_Screen.SetActive(false);
        UI_Text_Location.gameObject.SetActive(false);
        Hint1.gameObject.SetActive(false);
        Hint2.gameObject.SetActive(false);
        Hint3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.visible = true;
            MouseLook.isPlayerAbleToLook = false;
            Cursor.lockState = CursorLockMode.None;
            Black_Screen.SetActive(true);
            Hint1.gameObject.SetActive(true);
            Hint2.gameObject.SetActive(true);
            Hint3.gameObject.SetActive(true);
            //UI_Text_Location.text = "Industrial Area";
            UI_Text_Location.gameObject.SetActive(true);
        }
        else if(Input.GetKeyUp(KeyCode.Tab))
        {
            Cursor.visible = false;
            MouseLook.isPlayerAbleToLook = true;
            Cursor.lockState = CursorLockMode.Locked;
            Black_Screen.SetActive(false);
            Hint1.gameObject.SetActive(false);
            Hint2.gameObject.SetActive(false);
            Hint3.gameObject.SetActive(false);
            UI_Text_Location.gameObject.SetActive(false);
        }

        if(isPlayerinIndustrial)
        {
            UI_Text_Location.text = "Industrial Area";
            if (!Hint1_show)
                Hint1.sprite = Blur;
            else
                Hint1.sprite = Hint1_Industrial;
            if (!Hint2_show)
                Hint2.sprite = Blur;
            else
                Hint2.sprite = Hint2_Industrial;
            if (!Hint3_show)
                Hint3.sprite = Blur;
            else
                Hint3.sprite = Hint3_Industrial;
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
            Hint1.gameObject.SetActive(false);
            Hint2.gameObject.SetActive(false);
            Hint3.gameObject.SetActive(false);
        }
    }

    public void Button1()
    {
        Hint1_show = true;
    }

    public void Button2()
    {
        Hint2_show = true;
    }

    public void Button3()
    {
        Hint3_show = true;
    }
}
