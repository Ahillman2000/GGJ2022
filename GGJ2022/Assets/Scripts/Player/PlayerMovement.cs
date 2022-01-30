using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    ColourChange colourChange;
    [SerializeField] Animator[] player_sprites;

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


    void Update()
    {
        horizontal_move = Input.GetAxisRaw("Horizontal") * run_speed;

        if(Input.GetButton("Jump"))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            colourChange.ChangeColour();
            if(controller.m_WhatIsGround == controller.whiteLayer)
            {
                controller.m_WhatIsGround = controller.blackLayer;
            }
            else
            {
                controller.m_WhatIsGround = controller.whiteLayer;
            }
        }

        if(horizontal_move != 0 && controller.IsGrounded())
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
