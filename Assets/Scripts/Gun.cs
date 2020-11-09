using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    Transform spawnPoint;

    private void OnEnable()
    {
        spawnPoint = transform.Find("SpawnBulletPoint");
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponentInChildren<Rigidbody>().AddRelativeForce(Vector3.forward * 1, ForceMode.Impulse);
    }
}
