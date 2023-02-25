using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform firePoint;

    [SerializeField] private GameObject bulletPrefab;

    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
