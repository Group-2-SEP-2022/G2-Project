using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

    public BoxCollider2D boundBox;
    private Vector3 minBounds;
    private Vector3 maxBounds;

    private Camera theCamera;
    private float halfHeight;
    private float halfWidth;

    //set the camera boundaries
    void Start()
    {
        minBounds = boundBox.bounds.min;
        maxBounds = boundBox.bounds.max;

        theCamera = GetComponent<Camera>();
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
    }

    //move the camera according to the player and stop the camera when hitting the boundaries
    void Update()
    {
        targetPos = new Vector3(
            followTarget.transform.position.x,
            followTarget.transform.position.y,
            transform.position.z
        );
        transform.position = Vector3.Lerp(
            transform.position,
            targetPos,
            moveSpeed * Time.deltaTime
        );

        float clampedX = Mathf.Clamp(
            transform.position.x,
            minBounds.x + halfWidth,
            maxBounds.x - halfWidth
        );
        float clampedY = Mathf.Clamp(
            transform.position.y,
            minBounds.y + halfHeight,
            maxBounds.y - halfHeight
        );
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
