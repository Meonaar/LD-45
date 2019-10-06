using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 offset;
    public Vector3 newPosition;


    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = 3;
        }
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
        }
    }
    void FixedUpdate()
    {
        newPosition = Vector3.Lerp(transform.position, player.position + offset, speed * Time.smoothDeltaTime);
        transform.position = newPosition;
    }
}
