using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        GameObject surface = col.gameObject;
        if (surface.layer == LayerMask.NameToLayer("Black"))
        {
            surface.GetComponent<SpriteRenderer>().color = Color.white;
            surface.layer = LayerMask.NameToLayer("White");
        }
        else if (surface.layer == LayerMask.NameToLayer("White"))
        {
            surface.GetComponent<SpriteRenderer>().color = Color.black;
            surface.layer = LayerMask.NameToLayer("Black");
        }
        Destroy(gameObject);
    }
}

