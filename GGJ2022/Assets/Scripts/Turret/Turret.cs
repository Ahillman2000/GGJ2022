using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRateInSecs;
    [SerializeField] private ColourChange.Colour[] fireSequence;
    [SerializeField] private float bulletForce = 20.0f;
    [SerializeField] private bool shouldRotate = false;
    private int _currentColour;
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
        firePoint.parent.GetComponent<ColourChange>().colour = fireSequence[_currentColour];
        GetComponent<ColourChange>().colour = fireSequence[_currentColour];
        StartCoroutine(DelayBulletFire());
    }

    private IEnumerator DelayBulletFire()
    {
        yield return new WaitForSeconds(1.0f);
        GameObject bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);
        bullet.transform.parent = firePoint.transform;
        
        bullet.GetComponent<ColourChange>().colour = fireSequence[_currentColour++];
        if (_currentColour >= fireSequence.Length) {  _currentColour = 0; }

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        EventParam audioParam = new EventParam { string_ = "TurretFiring" };
        EventManager.TriggerEvent("TurretProjectileFired", audioParam);
    }
}

