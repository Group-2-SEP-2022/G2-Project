using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private bool playerMoving;
    private Vector2 lastMove;

    private Animator anim;

    void Start()

    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        playerMoving = false;

        if(movementJoystick.joystickVec.x > 0.5f || movementJoystick.joystickVec.x < -0.5f) {
            transform.Translate(new Vector3(movementJoystick.joystickVec.x * playerSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Mathf.Round(movementJoystick.joystickVec.x), 0f);
        }

        if(movementJoystick.joystickVec.y > 0.5f || movementJoystick.joystickVec.y < -0.5f) {
            transform.Translate(new Vector3(0f, movementJoystick.joystickVec.y * playerSpeed * Time.deltaTime, 0f));
            playerMoving = true;
            lastMove = new Vector2(0f, Mathf.Round(movementJoystick.joystickVec.y));
        }
        
        anim.SetFloat("MoveX", Mathf.Round(movementJoystick.joystickVec.x));
        anim.SetFloat("MoveY", Mathf.Round(movementJoystick.joystickVec.y));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}