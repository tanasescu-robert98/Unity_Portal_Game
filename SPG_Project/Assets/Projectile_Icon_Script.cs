using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile_Icon_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Projectile_UI_Image;

    public Sprite Projectile_Available;
    public Sprite Projectile_Unavailable;
    void Start()
    {
        Projectile_UI_Image.sprite = Projectile_Unavailable;
    }

    // Update is called once per frame
    void Update()
    {
        if(Shooting_System.Kill_Count >= 3)
        {
            Projectile_UI_Image.sprite = Projectile_Available;
        }
        else
        {
            Projectile_UI_Image.sprite = Projectile_Unavailable;
        }
    }
}
