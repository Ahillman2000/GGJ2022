using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public enum Colour
    {
        BLACK,
        WHITE,
    };
    public Colour colour;

    [SerializeField] Sprite black;
    [SerializeField] Sprite white;

    void Start()
    {
        if (colour == Colour.BLACK)
        {
            spriteRenderer.sprite = black;
            //this.gameObject.layer = 6;
        }
        else if (colour == Colour.WHITE)
        {
            spriteRenderer.sprite = white;
            //this.gameObject.layer = 7;
        }
    }

    public void ChangeColour()
    {
        Debug.Log("changing colour");

        if (colour == Colour.BLACK)
        {
            colour =  Colour.WHITE;
        }
        else if (colour == Colour.WHITE)
        {
            colour = Colour.BLACK;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ChangeColour();
        }

        if (colour == Colour.BLACK)
        {
            spriteRenderer.sprite = black;
            //this.gameObject.layer = 6;
        }
        else if (colour == Colour.WHITE)
        {
            spriteRenderer.sprite = white;
            //this.gameObject.layer = 7;
        }
    }

    /*public Colour GetColour()
    {
        return colour;
    }*/
}
