using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRControllerMenuExample : MonoBehaviour
{


    public AudioSource audio;
    private XRController xrController;
    // Start is called before the first frame update
    void Start()
    {
        xrController = GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (xrController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool selectButtonValue) && selectButtonValue) 
        {
            Debug.Log("Select Button Pressed");
            audio.Play();
        }
    }
}
