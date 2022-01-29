using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(gameObject, 4.0f);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameObject surface = col.gameObject;
        surface.GetComponent<ColourChange>().ChangeColour();
        Destroy(gameObject);
    }
}

