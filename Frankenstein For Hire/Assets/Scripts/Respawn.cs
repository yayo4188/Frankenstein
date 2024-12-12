using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 newPos;

 

    void Start()
    {
        newPos = transform.position;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = newPos;
        }
    }
}
