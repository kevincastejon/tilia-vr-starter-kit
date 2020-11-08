using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredCube : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetRandomColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
