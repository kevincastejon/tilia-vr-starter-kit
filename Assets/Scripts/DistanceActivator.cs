using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Zinnia.Pointer.ObjectPointer;

public class DistanceActivator : MonoBehaviour
{
    public void Activate(EventData evtData)
    {
        Activable activable = evtData.CollisionData.collider.gameObject.GetComponent<Activable>();
        if (activable==null)
        {
            return;
        }
        activable.Activate();
    }
}
