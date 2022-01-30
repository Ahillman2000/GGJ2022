using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    ColourChange colourChange;
    [SerializeField] Animator[] player_sprites;
    public bool withinObject = false;

    float horizontal_move = 0f;

    [SerializeField] float run_speed;
    bool jump = false;

    private void Start()
    {
        colourChange = this.GetComponent<ColourChange>();

        if(colourChange.colour == ColourChange.Colour.BLACK)
        {
            controller.m_WhatIsGround = controller.whiteLayer;
        }
        else
        {
            controller.m_WhatIsGround = controller.blackLayer;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CollisionChecker"))
        {
            withinObject = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("CollisionChecker"))
        {
            withinObject = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CollisionChecker"))
        {
            withinObject = false;
        }
    }

    void Update()
    {
        Debug.Log("within object: " + withinObject);

        horizontal_move = Input.GetAxisRaw("Horizontal") * run_speed;

        if(Input.GetButton("Jump"))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.Q) && !withinObject)
        {
            colourChange.ChangeColour();
        }

        if (horizontal_move != 0 && controller.IsGrounded())
        {
            player_sprites[0].SetBool("moving",true);
            player_sprites[1].SetBool("moving",true);
        }
        else
        {
            player_sprites[0].SetBool("moving", false);
            player_sprites[1].SetBool("moving", false);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontal_move * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
