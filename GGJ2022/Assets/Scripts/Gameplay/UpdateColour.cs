using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColour : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] ColourChange this_colour;
    void Update()
    {
        if(Player.GetComponent<ColourChange>().GetColour() == ColourChange.Colour.BLACK)
        {
            this_colour.colour = ColourChange.Colour.WHITE;
        }
        else
        {
            this_colour.colour = ColourChange.Colour.BLACK;
        }
    }
}
