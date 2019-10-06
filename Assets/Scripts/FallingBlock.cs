using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    public Rigidbody2D go;
    public float gravity;


    private void Start()
    {
        gameObject.tag = "Ground";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            go.gravityScale = gravity;
            Destroy(gameObject);
        }
    }
}
