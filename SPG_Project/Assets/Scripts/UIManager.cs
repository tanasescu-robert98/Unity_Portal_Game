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
    public TMP_Text UI_Pickups_Counter; 

    public static int Industrial_Collected_Pickups;
    public static int Industrial_Max_Pickups;

    public GameObject Black_Screen;
    public Image Hint1;
    public Image Hint2;
    public Image Hint3;
    public Image Hint4;
    public Image Hint5;
    public Image Hint6;

    public GameObject HealthBar;
    public Image Projectile_Icon;

    public Sprite Blur;
    public Sprite Hint1_Industrial;
    public Sprite Hint2_Industrial;
    public Sprite Hint3_Industrial;
    public Sprite Final_Industrial;

    public Sprite Hint1_Lake;
    public Sprite Hint2_Lake;
    public Sprite Hint3_Lake;
    public Sprite Hint4_Lake;
    public Sprite Hint5_Lake;
    public Sprite Hint6_Lake;

    public static bool Hint1_show = false;
    public static bool Hint2_show = false;
    public static bool Hint3_show = false;
    public static bool Hint4_show = false;
    public static bool Hint5_show = false;
    public static bool Hint6_show = false;

    public GameObject Crosshair;

    public static bool TAB_UI_Showing = false;
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
        UI_Pickups_Counter.gameObject.SetActive(false);
        Hint1.gameObject.SetActive(false);
        Hint2.gameObject.SetActive(false);
        Hint3.gameObject.SetActive(false);
        Hint4.gameObject.SetActive(false);
        Hint5.gameObject.SetActive(false);
        Hint6.gameObject.SetActive(false);
        HealthBar.SetActive(true);
        Projectile_Icon.gameObject.SetActive(true);
        Industrial_Collected_Pickups = 0;
        Industrial_Max_Pickups = 3;
    }

    // Update is called once per frame
    void Update()
    {
        UI_Pickups_Counter.text = Industrial_Collected_Pickups.ToString() + "/" + Industrial_Max_Pickups.ToString() + " Pickups";
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TAB_UI_Showing = true;
            Cursor.visible = true;
            MouseLook.isPlayerAbleToLook = false;
            Crosshair.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Black_Screen.SetActive(true);

            HealthBar.SetActive(false);
            Projectile_Icon.gameObject.SetActive(false);

            if (isPlayerinIndustrial)
            {
                if (Industrial_Collected_Pickups == Industrial_Max_Pickups)
                {
                    Hint2.gameObject.SetActive(true);
                    Hint2_show = true;
                    Hint2.sprite = Final_Industrial;
                }
                else
                {
                    Hint1.gameObject.SetActive(true);
                    Hint2.gameObject.SetActive(true);
                    Hint3.gameObject.SetActive(true);
                }
            }
            else if(isPlayerinLake)
            {
                Hint1.gameObject.SetActive(true);
                Hint2.gameObject.SetActive(true);
                Hint3.gameObject.SetActive(true);
                Hint4.gameObject.SetActive(true);
                Hint5.gameObject.SetActive(true);
                Hint6.gameObject.SetActive(true);

            }
            else if(isPlayerinSpawnRoom)
            {
                //nothing
            }
            //UI_Text_Location.text = "Industrial Area";
            UI_Text_Location.gameObject.SetActive(true);
            if(isPlayerinIndustrial)
                UI_Pickups_Counter.gameObject.SetActive(true);
        }
        else if(Input.GetKeyUp(KeyCode.Tab))
        {
            HealthBar.SetActive(true);
            Projectile_Icon.gameObject.SetActive(true);
            Cursor.visible = false;
            MouseLook.isPlayerAbleToLook = true;
            Cursor.lockState = CursorLockMode.Locked;
            Crosshair.SetActive(true);
            Black_Screen.SetActive(false);
            Hint1.gameObject.SetActive(false);
            Hint2.gameObject.SetActive(false);
            Hint3.gameObject.SetActive(false);
            Hint4.gameObject.SetActive(false);
            Hint5.gameObject.SetActive(false);
            Hint6.gameObject.SetActive(false);
            UI_Text_Location.gameObject.SetActive(false);
            UI_Pickups_Counter.gameObject.SetActive(false);
            TAB_UI_Showing = false;
        }

        if(isPlayerinIndustrial)
        {
            UI_Text_Location.text = "Industrial Area";
            UI_Pickups_Counter.text = Industrial_Collected_Pickups.ToString() + "/" + Industrial_Max_Pickups.ToString() + " Pickups";

            if (Industrial_Collected_Pickups != Industrial_Max_Pickups)
            {
                Hint1.rectTransform.position = new Vector3(Hint1.rectTransform.position.x, 450, Hint1.rectTransform.position.z);
                Hint2.rectTransform.position = new Vector3(Hint2.rectTransform.position.x, 450, Hint2.rectTransform.position.z);
                Hint3.rectTransform.position = new Vector3(Hint3.rectTransform.position.x, 450, Hint3.rectTransform.position.z);
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
        }
        else if(isPlayerinLake)
        {
            UI_Text_Location.text = "Lake Area";

            if (!Hint1_show)
                Hint1.sprite = Blur;
            else
                Hint1.sprite = Hint1_Lake;
            if (!Hint2_show)
                Hint2.sprite = Blur;
            else
                Hint2.sprite = Hint2_Lake;
            if (!Hint3_show)
                Hint3.sprite = Blur;
            else
                Hint3.sprite = Hint3_Lake;
            if (!Hint4_show)
                Hint4.sprite = Blur;
            else
                Hint4.sprite = Hint4_Lake;
            if (!Hint5_show)
                Hint5.sprite = Blur;
            else
                Hint5.sprite = Hint5_Lake;
            if (!Hint6_show)
                Hint6.sprite = Blur;
            else
                Hint6.sprite = Hint6_Lake;

            Hint1.rectTransform.position = new Vector3(Hint1.rectTransform.position.x, 600, Hint1.rectTransform.position.z);
            Hint2.rectTransform.position = new Vector3(Hint2.rectTransform.position.x, 600, Hint2.rectTransform.position.z);
            Hint3.rectTransform.position = new Vector3(Hint3.rectTransform.position.x, 600, Hint3.rectTransform.position.z);
            Hint4.rectTransform.position = new Vector3(Hint4.rectTransform.position.x, 200, Hint4.rectTransform.position.z);
            Hint5.rectTransform.position = new Vector3(Hint5.rectTransform.position.x, 200, Hint5.rectTransform.position.z);
            Hint6.rectTransform.position = new Vector3(Hint6.rectTransform.position.x, 200, Hint6.rectTransform.position.z);
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

    public void Button4()
    {
        Hint4_show = true;
    }

    public void Button5()
    {
        Hint5_show = true;
    }

    public void Button6()
    {
        Hint6_show = true;
    }
}
