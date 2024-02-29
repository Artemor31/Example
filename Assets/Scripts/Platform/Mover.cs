using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 diff = new Vector3(0, 0, vert); 
        gameObject.transform.Translate(diff / Speed);


        Vector3 diff2 = new Vector3(0, hor, 0);
        gameObject.transform.Rotate(diff2 / Speed * 2);
    }
}

