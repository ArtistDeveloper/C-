using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float alpha = -0.1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float newXPosition = transform.position.x + alpha;
        transform.position = new Vector3(newXPosition, 3.88f, -15.22f);

        if (newXPosition < -4.0f)
        {
            alpha = 0.1f;
        }

        else if(newXPosition > 4.0f)
        {
            alpha = -0.1f;
        }
    }
}
