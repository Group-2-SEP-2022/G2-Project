using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    private bool playerMoving;
    private Vector2 lastMove;

    private Animator anim;

    void Start()

    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        playerMoving = false;

        if(movementJoystick.joystickVec.x > 0.5f || movementJoystick.joystickVec.x < -0.5f) {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
            playerMoving = true;
            lastMove = new Vector2(movementJoystick.joystickVec.x, 0f);
        }

        if(movementJoystick.joystickVec.y > 0.5f || movementJoystick.joystickVec.y < -0.5f) {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, movementJoystick.joystickVec.y);
        }

        if(movementJoystick.joystickVec.x == 0 || movementJoystick.joystickVec.y == 0) {
            rb.velocity = Vector2.zero;
            playerMoving = false;
        }

        
        anim.SetFloat("MoveX", movementJoystick.joystickVec.x);
        anim.SetFloat("MoveY", movementJoystick.joystickVec.y);
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}