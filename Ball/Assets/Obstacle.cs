using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float alpha = 0.1f;

    void OnCollisionEnter(Collision collision) //자신(obstacle)에게 부딪힌 대상정보를 가져옴.
    {
        Vector3 direction = collision.gameObject.transform.position - transform.position;
        direction = direction.normalized * 300; //normalized : 벡터의 정규화
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        float newXPosition = transform.localPosition.x + alpha; //position : 글로벌
        transform.localPosition = new Vector3(newXPosition,
            transform.localPosition.y,
            transform.localPosition.z);

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
