﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    //public Camera cam;
    public Color color1 = Color.black;
    public Color color2 = Color.red;

    public Transform player;

    public void Update()
    {
            if (player.position.y < -13)
            {
                float t = 1f;
                Camera.main.backgroundColor = Color.Lerp(color1, color2, t);
            }

        if (player.position.y > -5)
        {
            Camera.main.backgroundColor = color1; 
        }
    }


}
