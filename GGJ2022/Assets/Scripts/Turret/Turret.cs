using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireDelay;
    [SerializeField] private float bulletForce = 20.0f;
    [SerializeField] private ColourChange.Colour[] fireSequence;
    [Space]
    [SerializeField] private bool shouldRotate;
    
    private int   _currentColour;
    private float _targetRotation;
    private float _timePassed;

    private void Start()
    {
        _timePassed = fireDelay*1.25f;
        _targetRotation = transform.rotation.eulerAngles.z;
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0,0,_targetRotation);
        
        if (Time.time >= _timePassed)
        {
            if (shouldRotate)
            {
                _targetRotation += 90;
            }
            
            StartCoroutine(ChangeTurretColour());
            _timePassed += fireDelay*1.25f;
        }
    }

    private IEnumerator ChangeTurretColour()
    {
        firePoint.parent.GetComponent<ColourChange>().colour = fireSequence[_currentColour];
        GetComponent<ColourChange>().colour = fireSequence[_currentColour];
        
        yield return new WaitForSeconds(fireDelay);
        
        FireProjectile();
    }

    private void FireProjectile()
    {
        GameObject bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);
        //bullet.transform.parent = firePoint.transform;
        
        bullet.GetComponent<ColourChange>().colour = fireSequence[_currentColour++];
        if (_currentColour >= fireSequence.Length) {  _currentColour = 0; }

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        EventParam audioParam = new EventParam { string_ = "TurretFiring" };
        EventManager.TriggerEvent("TurretProjectileFired", audioParam);
    }
}