using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_TextureSetup : MonoBehaviour
{
    public Camera cameraA;
    public Camera cameraA_Left;
    public Camera cameraB;
    public Camera cameraC;

    public Material cameraMatA;
    public Material cameraMatA_Left;
    public Material cameraMatB;
    public Material cameraMatC;

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
    }
}
