using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopTheGame : MonoBehaviour
{
    public Rigidbody2D player;
    public GameObject ui;
    public PlayerMovement pm; 

    private void Start()
    {
        //pm = GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.velocity = Vector3.zero;
            pm.enabled = false;
            StartCoroutine(EndGame());
        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3f);
        ui.SetActive(true);
    }
}
