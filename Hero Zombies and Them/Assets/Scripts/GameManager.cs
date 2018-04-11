using UnityEngine;

public class GameManager : MonoBehaviour 
{
    ZombieData _zombieData;

	void Start () 
    {
        int spawn = -1;
        _zombieData.color = new Color[] { Color.cyan, Color.green, Color.magenta };   
        for (int i = 0; i < Random.Range(10, 20); i++)                                                 
        {
            GameObject humanoid = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            humanoid.transform.position = pos;
            switch (spawn)
            {
                case 0:
                    humanoid.name = "Citizen";
                    humanoid.AddComponent<Citizen>();
                    break;
                case 1:
                    humanoid.name = "Zombie";
                    humanoid.AddComponent<Zombie>();
                    humanoid.GetComponent<Renderer>().material.color = _zombieData.color[Random.Range(0, 3)];
                    break;
                default:
                    humanoid.name = "Hero";
                    humanoid.gameObject.tag = "Player";
                    humanoid.AddComponent<Hero>();
                    humanoid.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                    break;
            }
            spawn = Random.Range(0, 2);
        }
	}
}
