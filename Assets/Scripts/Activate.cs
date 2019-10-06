using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject go;
    public Transform player;
    public float speed;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            go.SetActive(true);
            go.transform.position = Vector3.MoveTowards(go.transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
