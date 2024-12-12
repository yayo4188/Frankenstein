using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Rigidbody RB;
    public Vector2 turn;
    public float sensitivity = 5f;
    public Vector3 deltaMove;
    public float speed = 20;
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown((1)))
        {
            turn.x += Input.GetAxis("Mouse X") * sensitivity;
            turn.y += Input.GetAxis("Mouse Y") * sensitivity;
            //transform.localRotation = Quaternion.Euler(turn.y, turn.x, 0);
            RB.rotation = Quaternion.Euler(turn.y, turn.x, 0);
        }
    }
}
