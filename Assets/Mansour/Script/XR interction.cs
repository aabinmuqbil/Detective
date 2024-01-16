using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class XRinterction : MonoBehaviour
{
    private XRController xrController;
    public AudioSource a;
    public GameObject cube;// Assign your cube GameObject in the Unity Editor

    private void Start()
    {
        xrController = GetComponent<XRController>();
        // cubeVisible = false; // Ensure the cube is initially hidden

    }

    private void Update()
    {
        // Use the select button or trigger value to determine when to show/hide the cube
        if (xrController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool selectButtonValue) && selectButtonValue)
        {
            // The select button on the controller is pressed
            Debug.Log("Select Button Pressed");

            a.Play();
            Instantiate(cube);


        }
    }
}
