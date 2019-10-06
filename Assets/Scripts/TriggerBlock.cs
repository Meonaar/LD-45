using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlock : MonoBehaviour
{
    public GameObject go;
    public GameObject goUp;
    public GameObject groundPRefab;
    public GameObject player;


    private void Start()
    {
        gameObject.tag = "Ground";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody2D grv = go.GetComponentInParent<Rigidbody2D>();
            grv.gravityScale = 1;
            Destroy(gameObject);
            Rigidbody2D grv1 = goUp.GetComponentInParent<Rigidbody2D>();
            grv1.gravityScale = -1.2f;
            Physics2D.IgnoreCollision(go.GetComponent<Collider2D>(), groundPRefab.GetComponent<Collider2D>(), true);
            Physics2D.IgnoreCollision(goUp.GetComponent<Collider2D>(), groundPRefab.GetComponent<Collider2D>(), true);
            Physics2D.IgnoreCollision(goUp.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), true);
            Physics2D.IgnoreCollision(go.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), true);
        }
    }
}
