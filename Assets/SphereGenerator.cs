﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int y = 0; y < 10; y++)
        {
            for(int x = 0; x < 10; x++)
            {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                obj.transform.position = new Vector3((float)x, (float)y, 0f);
                //obj.GetComponent<Renderer>().material.color = new Color(Random.value,Random.value,Random.value,1.0f);
                obj.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
        }
    }
}
