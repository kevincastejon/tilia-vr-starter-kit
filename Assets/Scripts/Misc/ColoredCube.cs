using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredCube : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Color[] colors = new Color[] { Color.white, Color.black, Color.green, Color.yellow, Color.blue, Color.red };
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetRandomColor()
    {
        meshRenderer.material.color = colors[Random.Range(0, colors.Length)];
    }
}
