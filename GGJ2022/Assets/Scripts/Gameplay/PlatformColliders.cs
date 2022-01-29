using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColliders : MonoBehaviour
{
    GameObject player;
    ColourChange playerColour;

    GameObject[] blackObjects;
    GameObject[] whiteObjects;

    public enum Colours
    {
        BLACK,
        WHITE,
        GREY,
    };
    //public Colours colours;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerColour = player.GetComponent<ColourChange>();

        blackObjects = GameObject.FindGameObjectsWithTag("Black");
        whiteObjects = GameObject.FindGameObjectsWithTag("White");
    }

    void Update()
    {
        for (int i = 0; i < blackObjects.Length; i++)
        {
            blackObjects[i].GetComponent<BoxCollider2D>().enabled = false;
        }
        for (int i = 0; i < whiteObjects.Length; i++)
        {
            whiteObjects[i].GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
