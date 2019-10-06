using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    private PlatformController pc;
    public GameObject go;
    //public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponentInParent<PlatformController>();

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            pc.Activate(go);
        }
    }
}
