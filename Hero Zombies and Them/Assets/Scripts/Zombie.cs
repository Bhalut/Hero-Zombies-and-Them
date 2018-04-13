using System.Collections;
using UnityEngine;
/// <summary>
/// Zombie.
/// This class contains the zombie's information, such as his taste (what he wants to eat), 
/// his color and his state (whether he is still or moving).
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class Zombie : MonoBehaviour 
{ 
    int move;                                                                   //variable to assign a action to each zombie.
    ZombieData _zombieData;                                                     //variable containing the struct of the zombie.
    /// <summary>
    /// Start this instance.
    /// starts the coroutine "States", randomly assigns the zombie's taste, 
    /// freezes the zombie's Rigidbody rotation.
    /// </summary>
	void Start () 
    {
        StartCoroutine(States());
        _zombieData._taste = (Taste)Random.Range(0, 5);
        gameObject.GetComponent<Rigidbody>().freezeRotation = enabled;
	}
	
    /// <summary>
    /// Update this instance.
    /// Contains a switch that is randomly decided to move the zombie 
    /// in a random direction if the state is to "moving".
    /// </summary>
	void Update () 
    {
        switch (move)
        {
            case 0:
                transform.position += transform.forward * 3f * Time.deltaTime;
                break;
            case 1:
                transform.position -= transform.forward * 2f * Time.deltaTime;
                break;
            case 2:
                transform.position += transform.right * 3f * Time.deltaTime;
                break;
            case 3:
                transform.position -= transform.right * 2f * Time.deltaTime;
                break;
            case 4:
                transform.position += new Vector3(0, 0, 0);
                break;
            default:
                transform.position += transform.forward * 3f * Time.deltaTime;
                break;
        }
	}

    /// <summary>
    /// Movement this instance.
    /// Checks the zombie's status, whether it is "Idle" or "Moving".
    /// </summary>
    void Movement()
    {
        if (_zombieData._state == global::State.Moving)
        {
            move = Random.Range(0, 4);
            StartCoroutine(States());
        }
        else
        {
            move = 4;
            StartCoroutine(States());
        }
    }

    /// <summary>
    /// States this instance.
    /// Coroutine that randomly chooses the behavior of the zombie coming from an enumerator. 
    /// It also calls the method that checks the assigned status.
    /// </summary>
    /// <returns>The states.</returns>
    IEnumerator States()
    {
        yield return new WaitForSeconds(5);
        _zombieData._state = (State)Random.Range(0, 2);
        Movement();
        yield return new WaitForSeconds(5);
    }

    public ZombieData ZombieID()                                                //Method that returns the structure containing the citizen's information
    {
        return _zombieData;
    }
}

public enum State { Idle, Moving }                                              //Enum which contains the states to be randomly assigned.
public enum Taste { arm, nose, ear, finger, leg }                               //Enum which contains the tastes to be randomly assigned.

public struct ZombieData                                                        //Struct containing the citizen's information.
{
    public State _state;
    public Taste _taste;
    public Color[] color;
}
