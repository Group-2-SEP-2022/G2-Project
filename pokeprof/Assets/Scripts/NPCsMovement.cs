using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCsMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;

    private Rigidbody2D myRigidbody;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkZone;

    private bool hasWalkZone;

    private bool isStopped = false;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }
    }

    void Update()
    {
        if (!isStopped)
        {
            if (isWalking)
            {
                walkCounter -= Time.deltaTime;

                switch (walkDirection)
                {
                    case 0:
                        myRigidbody.velocity = new Vector2(0, moveSpeed);

                        if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                        {
                            isWalking = false;
                            waitCounter = waitTime;
                        }
                        break;
                    case 1:
                        myRigidbody.velocity = new Vector2(moveSpeed, 0);

                        if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                        {
                            isWalking = false;
                            waitCounter = waitTime;
                        }
                        break;
                    case 2:
                        myRigidbody.velocity = new Vector2(0, -moveSpeed);

                        if (hasWalkZone && transform.position.y < minWalkPoint.y)
                        {
                            isWalking = false;
                            waitCounter = waitTime;
                        }
                        break;
                    case 3:
                        myRigidbody.velocity = new Vector2(-moveSpeed, 0);

                        if (hasWalkZone && transform.position.x < minWalkPoint.x)
                        {
                            isWalking = false;
                            waitCounter = waitTime;
                        }
                        break;
                }

                if (walkCounter < 0)
                {
                    isWalking = false;
                    waitCounter = waitTime;
                }
            }
            else
            {
                waitCounter -= Time.deltaTime;
                myRigidbody.velocity = Vector2.zero;

                switch (walkDirection)
                {
                    case 0:
                        anim.Play("Face_Up");
                        break;
                    case 1:
                        anim.Play("Face_Right");
                        break;
                    case 2:
                        anim.Play("Face_Down");
                        break;
                    case 3:
                        anim.Play("Face_Left");
                        break;
                }

                if (waitCounter < 0)
                {
                    ChooseDirection();
                }
            }
        }
    }

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);

        switch (walkDirection)
        {
            case 0:
                anim.Play("Move_Up");
                break;
            case 1:
                anim.Play("Move_Right");
                break;
            case 2:
                anim.Play("Move_Down");
                break;
            case 3:
                anim.Play("Move_Left");
                break;
        }

        isWalking = true;
        walkCounter = walkTime;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isStopped = true;
            myRigidbody.mass = 2000;
        }

        if(other.gameObject.tag == "Collider"){
             isWalking = false;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isStopped = false;
            myRigidbody.mass = 1;
        }

        if(other.gameObject.tag == "Collider"){
             isWalking = true;
        }
    }
}
