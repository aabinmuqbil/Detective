using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandInput : MonoBehaviour
{
    public InputActionProperty pinchA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchA.action.ReadValue<float>();
        Debug.Log(triggerValue);
    }
}
