using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public Joint joint;

    public void Detatch(Rigidbody rbToAttach)
    {
        if (joint.connectedBody == rbToAttach)
        {
            joint.connectedBody = null;
        }
    }

    public void Attach(Rigidbody rbToAttach)
    {
        joint.connectedBody = rbToAttach;
    }

    public void OnValidate()
    {
        if (joint == null)
        {
            joint = GetComponent<Joint>();
        }
    }
}
