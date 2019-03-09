using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if(Input.touchCount > 0 || Input.GetMouseButton(0)) //touchCount : 터치입력 횟수 | 0반환 : 왼쪽 마우스버튼
        {
            Debug.Log("Mouse Down : " + Input.mousePosition);
            if(Input.mousePosition.x < Screen.width / 2) //전체게임화면의 X값. 그거의 나누기2를 해서 왼쪽 오른쪽 위치 확인
            {
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z + 1);
            }

            else
            {
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z - 1);
            }
        }
    }
}
