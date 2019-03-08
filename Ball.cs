using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float sttPoint;
    bool shdPrntOver20 = true;
    bool shdPrntOver30 = true;
    SphereCollider myCollider;
    
    void Start()
    {
        //Rigidbody myRgdbody = GetComponent<Rigidbody>(); <Rigitbody> -> 컴포넌트타입 ball 컴포넌트에서 rigidtbody 컴포넌트를 읽어와 체크.
        //Debug.Log("useGravirty? : " + myRgdbody.useGravity);
        // 다른 문법 사용 Debug.Log("useGravirty? : "+GetComponent<Rigidbody>().useGravity);
        //Debug.Log("start");
        sttPoint = transform.position.z;
        myCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = transform.position.z - sttPoint;
        myCollider.radius = myCollider.radius + 0.01f;

        if (distance > 30)
        {
            if (shdPrntOver30)
            {
                Debug.Log("Over 30 : " + distance);
                shdPrntOver30 = false;
            }
        }

        else if (distance > 20)
        {
            if (shdPrntOver20)
            {
                Debug.Log("Over 20:" + distance);
                shdPrntOver20 = false;
            }

        }
    }
}
