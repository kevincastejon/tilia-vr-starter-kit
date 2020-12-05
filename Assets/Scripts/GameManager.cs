using System;
using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Interactables.Interactables;
using Tilia.Interactions.Interactables.Interactors;
using Tilia.SDK.OculusIntegration.Input;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Prefab Settings")]
    public GameObject bulletPrefab;
    [Header("Reference Settings")]
    public InteractorFacade leftInteractor;
    public InteractorFacade rightInteractor;
    public OVRInputButtonAction leftTriggerAction;
    public OVRInputButtonAction rightTriggerAction;
    [Header("Monitoring")]
    [ReadOnly]
    public InteractableFacade leftGrabbed;
    [ReadOnly]
    public InteractableFacade rightGrabbed;

    private void Start()
    {
        leftInteractor.Grabbed.AddListener(OnLeftGrab);
        rightInteractor.Grabbed.AddListener(OnRightGrab);
        leftInteractor.Ungrabbed.AddListener(OnLeftUngrab);
        rightInteractor.Ungrabbed.AddListener(OnRightUngrab);
        leftTriggerAction.Activated.AddListener(OnLeftTrigger);
        rightTriggerAction.Activated.AddListener(OnRightTrigger);
    }

    private void OnLeftGrab(InteractableFacade interactable)
    {
        leftGrabbed = interactable;
    }

    private void OnRightGrab(InteractableFacade interactable)
    {
        rightGrabbed = interactable;
    }
    private void OnLeftUngrab(InteractableFacade interactable)
    {
        leftGrabbed = null;
    }

    private void OnRightUngrab(InteractableFacade interactable)
    {
        rightGrabbed = null;
    }

    private void OnLeftTrigger(bool arg0)
    {
        if (leftGrabbed)
        {
            Gun gun = leftGrabbed.GetComponent<Gun>();
            if (gun != null)
            {
                ShootBullet(gun.spawnPoint);
            }
        }
    }
    private void OnRightTrigger(bool arg0)
    {
        if (rightGrabbed)
        {
            Gun gun = rightGrabbed.GetComponent<Gun>();
            if (gun != null)
            {
                ShootBullet(gun.spawnPoint);
            }
        }
    }
    private void ShootBullet(Transform spawnPoint)
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward*5, ForceMode.Impulse);
    }
}
