using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeChecking : MonoBehaviour
{
    private Vector2 startTouchPosition,
        endTouchPosition;
    public Animator startAnim;

    public void SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.x - startTouchPosition.x < -800)
            {
                startAnim.SetTrigger("start");
            }
        }
    }

    void Update()
    {
        SwipeCheck();
    }
}
