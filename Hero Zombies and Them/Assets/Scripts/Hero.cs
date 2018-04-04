using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour 
{
    public float speed;

	// Use this for initialization
	void Start () 
    {
        speed = Random.Range(0.5f, 1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        Move();
	}

    void Move ()
    {
        
    }
}
