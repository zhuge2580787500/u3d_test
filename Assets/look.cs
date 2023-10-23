using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class look : MonoBehaviour
{

    public float mspeed;

    public Transform player;

    private float xmove;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x, y;
        x = Input.GetAxis("Mouse X") * mspeed * Time.deltaTime;
        y = Input.GetAxis("Mouse Y") * mspeed * Time.deltaTime;
        xmove = xmove - y;
        xmove = Mathf.Clamp(xmove, -90, 90);
        this.transform.localRotation = Quaternion.Euler(xmove,0,0);


        player.Rotate(Vector3.up*x);

    }
}
