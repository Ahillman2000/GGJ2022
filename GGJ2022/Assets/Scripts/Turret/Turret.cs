using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject projectileContainer;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRateInSecs;
    [SerializeField] private float bulletForce = 20.0f;
    private float _timePassed;
    
    private void Start()
    {
        _timePassed = fireRateInSecs;
    }

    private void Update()
    {
        if (Time.time > _timePassed)
        {
            Fire();
            _timePassed += fireRateInSecs;
        }
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);
        bullet.transform.parent = projectileContainer.transform;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        EventParam audioParam = new EventParam { string_ = "TurretFiring" };
        EventManager.TriggerEvent("TurretProjectileFired", audioParam);
    }
}

