using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    public GameObject enemy;
    GameObject player;

    List<GameObject> enemiesAlive;


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemiesAlive = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemiesAlive.Count < 10)
        {
            Vector3 enemyPosition = new Vector3(
                player.transform.position.x + Random.Range(-30, 30), 
                player.transform.position.y, 
                player.transform.position.z + Random.Range(-30, 30));

            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);

            enemiesAlive.Add(newEnemy);
        }

        for(int i = 0; i < enemiesAlive.Count; i++)
        {
            if(enemiesAlive[i] == null)
            {
                enemiesAlive.RemoveAt(i);
            }
        }
    }
}
