using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEATH : MonoBehaviour
{
    bool isDead;
    public GameObject trigger;

    private void Start()
    {
        isDead = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isDead)
        {
            Destroy(this.gameObject);
            Destroy(trigger);
            isDead = true;
        }
    }
}
