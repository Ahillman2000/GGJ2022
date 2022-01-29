using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i].GetComponent<ColourChange>().ChangeColour();
        }
    }
}
