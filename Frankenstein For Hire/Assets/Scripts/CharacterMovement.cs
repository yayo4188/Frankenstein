using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public Camera IsoCamera;

    private RaycastHit hit;

    private NavMeshAgent agent;

    private string groundTag = "Ground";
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = IsoCamera.ScreenPointToRay(Input.mousePosition);

            if( Physics.Raycast(ray, out hit, Mathf.Infinity) )
            {
                if ( hit.collider.CompareTag(groundTag))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}
