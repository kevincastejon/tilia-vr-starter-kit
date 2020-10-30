using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Colorize(Single hue)
    {
        GetComponent<MeshRenderer>().material.color = Color.HSVToRGB(hue,1,1);
    }
}
