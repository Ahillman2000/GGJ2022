using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(DestroyBullet());
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        int layer = col.collider.gameObject.layer;
        if (layer == LayerMask.NameToLayer("Black")) {}
        else if (layer == LayerMask.NameToLayer("White")) {}
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this);
    }
}

