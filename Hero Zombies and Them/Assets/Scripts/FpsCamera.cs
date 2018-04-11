using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCamera : MonoBehaviour 
{
    float mouseX;                                                       
    float mouseY;                                                                                        
    float mx = -45;                                                     
    float yx = 45; 
    GameObject body; 

    void Start()                                                       
    {
        body = FindObjectOfType(typeof(GameObject)) as GameObject;     
    }

    void Update()                                                      
    {
        mouseX += Input.GetAxis("Mouse X");                             
        mouseY -= Input.GetAxis("Mouse Y");                             
        mouseY = Mathf.Clamp(mouseY, mx, yx);                           
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);         
        body.transform.eulerAngles = new Vector3(0, mouseX, 0);         
    }
}
