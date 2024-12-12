using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckenSpin : MonoBehaviour
{
    public float speed;

    public Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);

        rigid.AddTorque(move * speed);


    }
}
