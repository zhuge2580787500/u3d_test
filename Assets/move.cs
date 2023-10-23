using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{



    public float speed;

    public CharacterController playercontroller;


    void Update()
    {
        float x, z;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move;
        move = transform.right * x + transform.forward * z;
        playercontroller.Move(move * speed * Time.deltaTime);


    }
}
