using UnityEngine;

public class FpsMove : MonoBehaviour 
{
    public float speed;                                                            

    void Update()
    {
        if (Input.GetKey(KeyCode.W))                                            
            transform.position += transform.forward * speed;   

        if (Input.GetKey(KeyCode.S))                                            
            transform.position -= transform.forward * speed; 
        
        if (Input.GetKey(KeyCode.D))                                           
            transform.position += transform.right * speed;       

        if (Input.GetKey(KeyCode.A))                     
            transform.position -= transform.right * speed;
    }
}
