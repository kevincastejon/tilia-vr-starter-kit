using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CameraRigsSwitcher))]
public class CameraRigsSwitcherEditor : Editor
{
    SerializedProperty VRSimulator;
    void OnEnable()
    {
        VRSimulator = serializedObject.FindProperty("VRSimulator");
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        serializedObject.Update();
        bool sim = VRSimulator.boolValue;
        GameObject target = ((CameraRigsSwitcher)serializedObject.targetObject).gameObject;
        target.transform.Find("VRSimulator").gameObject.SetActive(sim);
        target.transform.Find("UnityXR").gameObject.SetActive(!sim);
    }
}
