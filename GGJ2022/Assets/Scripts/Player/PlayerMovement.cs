using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] Animator[] player_sprites;

    float horizontal_move = 0f;

    float run_speed = 40f;
    bool jump = false;


    void Update()
    {
        horizontal_move = Input.GetAxisRaw("Horizontal") * run_speed;

        if(Input.GetButton("Jump"))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.GetComponent<ColourChange>().ChangeColour();
        }

        if(horizontal_move != 0)
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
