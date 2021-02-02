using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //indicates min and max spawn location
    public float min_y = 3.5f, max_y = 0f;

    //indicates enemies to spawn
    public GameObject[] enemy_Prefabs;

    //indicates time until next spawn
    public float timer = 1f;

    void Start()
    {
        Invoke("SpawnEnemies", timer);
    }
    void Update()
    {

    }

    void SpawnEnemies()
    {
        //indicates a random position for the spawn between the min and max
        float pos_y = Random.Range(min_y, max_y);
        //temporary position of spawner
        Vector3 temp = transform.position;
        temp.y = pos_y;
        //spawn enemy
        Instantiate(enemy_Prefabs[Random.Range(0, enemy_Prefabs.Length)], temp, Quaternion.Euler(0f, 0f, 180f));
        
        Invoke("SpawnEnemies", timer);
    }
}