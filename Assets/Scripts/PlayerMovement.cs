using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    float movement = 0f;
    public float jumpForce = 10f;
    public bool isJump = false;
    public PlayerPos ps;
    public bool isEndGame = false;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ps = GetComponent<PlayerPos>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isEndGame)
        {
            movement = Input.GetAxis("Horizontal") * movementSpeed;

            if (Input.GetButtonDown("Jump") && (isJump == false))
            {
                rb.velocity = Vector2.up * jumpForce;
                isJump = true;
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isJump = false;
        }

        if (col.gameObject.tag == "Press")
        {
            ps.RestartLevel();
        }
    }
}
