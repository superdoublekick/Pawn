using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   [SerializeField] private Transform firePoint;
   public GameObject bulletPrefab;
   public float bulletSpeed = 10;

    

    
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = firePoint.forward * bulletSpeed;

        }

    }
}
