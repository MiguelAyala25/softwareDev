using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemyAI;
    float RandomX, RandomY;
    private float SpanwTime;

    public static bool enemySpawn = true;


    void Start()
    {
        enemySpawn = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(enemySpawn == true)
        {
            EnemyAISpawner();
        }
         

    }

    public void EnemyAISpawner()
    {
        RandomX = Random.Range(-3, 3);
        RandomY= Random.Range(-4, 4);

        Vector2 pos = new Vector2(RandomX, RandomY);
        Instantiate(enemyAI, pos, Quaternion.identity);

        enemySpawn = false;

    }

}
