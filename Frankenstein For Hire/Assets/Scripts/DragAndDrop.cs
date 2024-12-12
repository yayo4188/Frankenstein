using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Draggable objSelected = null;

    public GameObject[] snapPoints;
    private float snapSensitivity = 2.0f;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //Check object selected
            CheckHitObject();
        }
        if (Input.GetMouseButton(0) && objSelected != null )
        {
          
            
         DragObject();
            

        }
        if (Input.GetMouseButtonUp(0) && objSelected != null)
        {
            //Drop obj
            DropObject();
        }
    }

    void CheckHitObject()
    {
        
        
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

        if (hit2D.collider != null)
        {
            objSelected = hit2D.transform.gameObject.GetComponentInParent<Draggable>();
        }
        //3D
        if (objSelected == null)
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            foreach (var hit in hits)
            {
                if (objSelected == null)
                    objSelected = hit.transform.gameObject.GetComponentInParent<Draggable>();
            }
        }
        if (objSelected != null)
        {
           objSelected.DragStart();
            
        }
        
    }

    void DragObject()
    {

        //if (objSelected.CompareTag("Draggable"))

        {
            //make a plane and raycast to it, to get the position in world of the mouse drag
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane + 10.0f));

            //objSelected.transform.position = targetPosition;
            objSelected.DragPosition(targetPosition);
        }
       
    }

    void DropObject() // 2D Snapping 
    {
        for (int i = 0; i < snapPoints.Length; i++)
        {
            if (Vector3.Distance(snapPoints[i].transform.position, objSelected.transform.position) < snapSensitivity)
            {
                objSelected.transform.position = new Vector3(snapPoints[i].transform.position.x, snapPoints[i].transform.position.y, snapPoints[i].transform.position.z - 0.1f);

            }
        }
        objSelected.DragEnd();
        objSelected = null;
    }
}