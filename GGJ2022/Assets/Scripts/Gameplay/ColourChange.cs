using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private CharacterController2D controller;

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

        if(this.CompareTag("Player"))
        {
            if (controller.m_WhatIsGround == controller.whiteLayer)
            {
                controller.m_WhatIsGround = controller.blackLayer;
            }
            else
            {
                controller.m_WhatIsGround = controller.whiteLayer;
            }
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
