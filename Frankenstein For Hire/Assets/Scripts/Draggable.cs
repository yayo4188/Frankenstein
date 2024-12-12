using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Draggable : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    Vector3 m_YAxis;
    public Rigidbody mainLimb;
    public Socket currentSocket;
    public Socket currentlyHoveredSocket;
    public float speed =5;
    
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set up vector for moving the Rigidbody in the y axis
        m_YAxis = new Vector3(0, 5, 0);

        
    }

    void Update()
    { //Press E to toggle constraints on the RigidBody
       

    }
  
    public void DragStart()
    {
        Debug.Log("Drag started");
        if (currentSocket != null)
        {
            currentSocket.Detatch(mainLimb);
        }
        mainLimb.isKinematic = true;
    }

    public void DragEnd()
    {
        Debug.Log("Drag end");
        mainLimb.isKinematic = false;

        if (currentlyHoveredSocket != null)
        {
            currentlyHoveredSocket.Attach(mainLimb);
            currentSocket = currentlyHoveredSocket;
        }

    }

    public void  DragPosition(Vector3 newPosition)
    {
        mainLimb.MovePosition(newPosition);
    }


    void OnTriggerEnter(Collider collider)
    {

        Socket newSocket = collider.GetComponentInParent<Socket>();
        if (newSocket != null)
        {
            Debug.Log("collision enter");

            currentlyHoveredSocket = newSocket;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        Socket newSocket = collider.GetComponentInParent<Socket>();
        if (newSocket != null && currentlyHoveredSocket == newSocket)
        {
            currentlyHoveredSocket = null;
        }
    }


    void OnValidate()
    {
        if (mainLimb == null)
        {
            mainLimb = GetComponent<Rigidbody>();
        }
    }

}
