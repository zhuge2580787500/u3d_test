using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed;

    public CharacterController playercontroller;


    void Update()
    {
        float x, z;
        //wasd���ƽ�ɫ�ƶ�
        //ȡֵ0 ��-1 ��1 
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move;
        //      ���������                    ��ǰ��
        move = transform.right * x + transform.forward * z;
        playercontroller.Move(move * speed * Time.deltaTime);


    }
}
