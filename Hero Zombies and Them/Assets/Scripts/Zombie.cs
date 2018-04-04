using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour 
{
    public enum State {Idle, Moving}
    public enum Taste {arm, nose, ear, finger, leg}

  
    public State _state; 
    public Taste _taste;

	// Use this for initialization
	void Start () 
    {
        _state = State.Idle;
        _taste = Taste.arm;
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    void ZombieBehavior(int i, int j)
    {
        //Moving
        switch(i)
        {
            case 0:
                _state = State.Idle;
                break;
            case 1:
                _state = State.Moving;
                break;
            default:
                _state = State.Idle;
                break;
        }

        //Taste
        switch(j)
        {
            case 0:
                _taste = Taste.arm;
                break;
            case 1:
                _taste = Taste.ear;
                break;
            case 2:
                _taste = Taste.finger;
                break;
            case 3:
                _taste = Taste.leg;
                break;
            case 4:
                _taste = Taste.nose;
                break;
            default:
                _taste = Taste.arm;
                break;
        }
    }
    void Message()
    {
        print("Waaaaarrrr quiero comer ");
    }
}
