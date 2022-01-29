using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColliders : MonoBehaviour
{
    GameObject player;
    Color playerColour;

    GameObject[] platforms;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        platforms = GameObject.FindGameObjectsWithTag("Platform");
    }

    void Update()
    {
        playerColour = player.GetComponent<SpriteRenderer>().color;

        for (int i = 0; i < platforms.Length; i++)
        {
            if(platforms[i].GetComponentInChildren<SpriteRenderer>().color == playerColour)
            {
                platforms[i].GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                platforms[i].GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
