using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 offset;
    public Vector3 newOffset;
    public Vector3 newPosition;
    bool isOffset = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || isOffset)
        {
            speed = 3;
            offset = newOffset;
            isOffset = true;
        }
    }

    void FixedUpdate()
    {
        newPosition = Vector3.Lerp(transform.position, player.position + offset, speed * Time.smoothDeltaTime);
        transform.position = newPosition;
    }
}
