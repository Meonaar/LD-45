using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject platform;
    public float moveSpeed = 5f;
    Transform currentPoint;
    public Transform[] points;
    public int pointSelection;
    // Start is called before the first frame update
    void Start()
    {
        currentPoint = points[pointSelection];
    }

    // Update is called once per frame
    void Update()
    {
        //Activate(gameObject);
    }

    public void Activate(GameObject go)
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentPoint.position, moveSpeed * Time.deltaTime);
        if (platform.transform.position == currentPoint.position)
        {
            pointSelection++;
            if (points.Length == pointSelection)
            {
                pointSelection = 0;
            }

            currentPoint = points[pointSelection];
        }
    }
}
