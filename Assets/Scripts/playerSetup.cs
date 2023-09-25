using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSetup : MonoBehaviour
{
    public FirstPersonController controller;

    public Camera camera;

    public AudioListener audioListener;

    public void isLocalPlayer()
    {
        camera.enabled = true;
        audioListener.enabled = true;
        controller.enabled = true;
    }
}
