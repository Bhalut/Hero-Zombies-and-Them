using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Zombie : MonoBehaviour 
{ 
    ZombieData _zombieData;
    int move;  

	void Start () 
    {
        StartCoroutine(Behaviour());
        _zombieData._taste = (Taste)Random.Range(0, 5);
        gameObject.GetComponent<Rigidbody>().freezeRotation = enabled;
	}
	
	void Update () 
    {
        switch (move)
        {
            case 1:
                transform.position += transform.forward * 2f * Time.deltaTime;
                break;
            case 2:
                transform.position -= transform.forward * 2f * Time.deltaTime;
                break;
            case 3:
                transform.position += transform.right * 2f * Time.deltaTime;
                break;
            case 4:
                transform.position -= transform.right * 2f * Time.deltaTime;
                break;
            case 5:
                transform.position += new Vector3(0, 0, 0);
                break;
        }
	}

    void Movement()
    {
        if (_zombieData._state == global::State.Moving)
        {
            move = Random.Range(0, 4);
            StartCoroutine(Behaviour());
        }
        else
        {
            move = 5;
            StartCoroutine(Behaviour());
        }
    }

    IEnumerator Behaviour()
    {
        yield return new WaitForSeconds(5);
        _zombieData._state = (State)Random.Range(0, 2);
        Movement();
        yield return new WaitForSeconds(5);
    }

    public ZombieData ZombieID()
    {
        return _zombieData;
    }
}

public enum State { Idle, Moving }
public enum Taste { arm, nose, ear, finger, leg }

public struct ZombieData
{
    public State _state;
    public Taste _taste;
    public Color[] color;
}
