using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class ActivationEvent : UnityEvent { };
public class Activable : MonoBehaviour
{
    public ActivationEvent OnActivated = new ActivationEvent();
    //public ActivationEvent OnDeactivated = new ActivationEvent();
    public void Activate()
    {
        OnActivated.Invoke();
    }
    //public void Deactivate()
    //{
    //    OnDeactivated.Invoke();
    //}
}
