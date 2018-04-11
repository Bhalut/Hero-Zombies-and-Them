using UnityEngine;

public class Hero : MonoBehaviour 
{
    CitizenData _citizenData;                                                     
    ZombieData _zombieData;   

	void Start () 
    {
        gameObject.AddComponent<FpsCamera>();
        gameObject.AddComponent<FpsMove>().speed = Random.Range(0.5f, 0.10f);
        gameObject.AddComponent<Rigidbody>().freezeRotation = enabled;
        Camera.main.gameObject.transform.localPosition = gameObject.transform.position;
        Camera.main.transform.SetParent(gameObject.transform);
        Camera.main.gameObject.AddComponent<FpsCamera>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Citizen>())
        {
            _citizenData = collision.gameObject.GetComponent<Citizen>().CitizenID();
            Debug.Log("Hola soy " + _citizenData.name + " y tengo " + _citizenData.age);
        }

        if (collision.gameObject.GetComponent<Zombie>())
        {
            _zombieData = collision.gameObject.GetComponent<Zombie>().ZombieID();
            Debug.Log("Waaaarrrr quiero comer " + _zombieData._taste);
        }
    }
}
