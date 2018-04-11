using UnityEngine;

public class Citizen : MonoBehaviour 
{
    public CitizenData _citizenData;
   
    void Start()
    {
        _citizenData.age = Random.Range(15, 100);
        _citizenData.name = (CitizenName)Random.Range(0, 20);
    }

    public CitizenData CitizenID()
    {
        return _citizenData;
    }
}

public enum CitizenName 
{
    Adolfo,
    Ramiro,
    Bob,
    Jimmy,
    Josefo,
    Leopoldo,
    Cirilo,
    Fabio,
    Yisus,
    Jasinto,
    Arnulfa,
    Berta,
    Gregoria,
    Gertrudis,
    Lola,
    Marta,
    Eva,
    Beatriz,
    Facunda,
    Pepa
}

public struct CitizenData
{
    public CitizenName name;
    public int age;
}
