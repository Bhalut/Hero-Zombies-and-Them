using UnityEngine;
/// <summary>
/// Citizen.
/// This class contains the citizen's information, such as age and name.
/// </summary>
public class Citizen : MonoBehaviour 
{
    CitizenData _citizenData;                                           //variable containing the struct of the citizen.
   
    void Start()
    {
        _citizenData.age = Random.Range(15, 100);                       //It initializes the variable "age" of the struct "CitizenData" by assigning a random value to it.
        _citizenData.name = (CitizenName)Random.Range(0, 20);           //It initializes the variable "name" of the enum "CitizenName" by assigning a random value to it(casting a "cast").
    }

    public CitizenData CitizenID()                                      //Method that returns the structure containing the citizen's information.
    {
        return _citizenData;
    }
}

public enum CitizenName                                                 //Enum which contains the names to be randomly assigned.
{
    Adolfo, Jimmy, Fabio, Lola, Marta, Rodolfo, Jesús, Cristian, Santiago, Samuel, 
    Ricardo, José, Armando, María, Mónica, Manuel, Andrés, Pablo, Samael, Kratos
}

public struct CitizenData                                               //Struct containing the citizen's information.
{
    public CitizenName name;
    public int age;
}
