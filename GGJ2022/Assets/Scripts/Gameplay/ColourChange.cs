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

    void Start()
    {
        if (colour == Colour.BLACK)
        {
            spriteRenderer.color = Color.black;
            this.gameObject.layer = LayerMask.NameToLayer("Black");
        }
        else if (colour == Colour.WHITE)
        {
            spriteRenderer.color = Color.white;
            this.gameObject.layer = LayerMask.NameToLayer("White");
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
        if (colour == Colour.BLACK)
        {
            spriteRenderer.color = Color.black;
            this.gameObject.layer = LayerMask.NameToLayer("Black");
        }
        else if (colour == Colour.WHITE)
        {
            spriteRenderer.color = Color.white;
            this.gameObject.layer = LayerMask.NameToLayer("White");
        }
    }

    public Colour GetColour()
    {
        return colour;
    }
}
