using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_TextureSetup : MonoBehaviour
{
    public Camera cameraA;
    public Camera cameraA_Left;
    public Camera cameraA_Right;
    public Camera cameraB;
    public Camera cameraC;
    public Camera cameraD;

    public Material cameraMatA;
    public Material cameraMatA_Left;
    public Material cameraMatA_Right;
    public Material cameraMatB;
    public Material cameraMatC;
    public Material cameraMatD;

    // Update is called once per frame
    private void Start()
    {
        if (cameraA.targetTexture != null)
        {
            cameraA.targetTexture.Release();
        }
        cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatA.mainTexture = cameraA.targetTexture;

        if (cameraB.targetTexture != null)
        {
            cameraB.targetTexture.Release();
        }
        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatB.mainTexture = cameraB.targetTexture;

        if (cameraC.targetTexture != null)
        {
            cameraC.targetTexture.Release();
        }
        cameraC.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatC.mainTexture = cameraC.targetTexture;

        if (cameraA_Left.targetTexture != null)
        {
            cameraA_Left.targetTexture.Release();
        }
        cameraA_Left.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatA_Left.mainTexture = cameraA_Left.targetTexture;

        if (cameraA_Right.targetTexture != null)
        {
            cameraA_Right.targetTexture.Release();
        }
        cameraA_Right.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatA_Right.mainTexture = cameraA_Right.targetTexture;

        if (cameraD.targetTexture != null)
        {
            cameraD.targetTexture.Release();
        }
        cameraD.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatD.mainTexture = cameraD.targetTexture;
    }
}
