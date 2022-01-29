using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;

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
    }

    private void FixedUpdate()
    {
        controller.Move(horizontal_move * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
