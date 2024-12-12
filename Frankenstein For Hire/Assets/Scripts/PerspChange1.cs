using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerspChange1 : MonoBehaviour
{
    public GameObject MiniCam;
    public GameObject IsoCam;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MiniCam.SetActive(true);
            IsoCam.SetActive(false);
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MiniCam.SetActive(false);
            IsoCam.SetActive(true);
           
            
        }
       
    }
}
