using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandInput : MonoBehaviour
{
    public InputActionProperty pinchA;
    public InputActionProperty GrabA;
    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchA.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger",triggerValue);
        // Debug.Log(triggerValue);
        float GValue = GrabA.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", GValue);
    }
}
