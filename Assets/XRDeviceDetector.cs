using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class XRDeviceDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRDevice.deviceLoaded += OnDeviceLoaded;
    }

    private void OnDeviceLoaded(string obj)
    {
        GameSettings.XR_DEVICE_LOADED = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
