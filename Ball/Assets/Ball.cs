﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float sttPoint;

    void Start()
    {
        sttPoint = transform.position.z;      
    }

    // Update is called once per frame
    void Update()
    {
        float distance = transform.position.z - sttPoint;
        
        if(Input.GetKeyDown(KeyCode.Space)) //Input.GetKeyUp(눌렀다 뗄 때)
        {
            //GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
            Rigidbody ballRigid;
            ballRigid = gameObject.GetComponent<Rigidbody>();
            ballRigid.AddForce(Vector3.up * 300);
        }
    }
}

