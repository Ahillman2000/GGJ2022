using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCollisionCheck : MonoBehaviour
{
    [SerializeField] private GameObject qText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            qText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            qText.SetActive(false);
        }
    }
}
