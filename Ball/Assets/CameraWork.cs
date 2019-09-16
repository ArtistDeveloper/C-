using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    public GameObject ball;
    
    void Start()
    {
        //ball = GameObject.Find("Ball");
    }

    
    void Update()
    {
        transform.position = new Vector3(0
            , ball.transform.position.y + 3
            , ball.transform.position.z - 8);
    }
}
