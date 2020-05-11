using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera cameraA;
    public Camera cameraB;
    public Material cameraMaterialA;
    public Material cameraMaterialB;

    // Start is called before the first frame update
    void Start()
    {
        if (cameraA.targetTexture != null)
        {
            cameraA.targetTexture.Release();
        }
        cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMaterialA.mainTexture = cameraA.targetTexture;

        if (cameraB.targetTexture != null)
        {
            cameraB.targetTexture.Release();
        }
        cameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMaterialB.mainTexture = cameraB.targetTexture;

    }
}
