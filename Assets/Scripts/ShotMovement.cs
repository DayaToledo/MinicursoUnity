using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    public float velocity;
    public float lifeTime = 3;

    private void Start()
    {
        if(gameObject.transform.CompareTag("Shot1"))
        {
            velocity = 0.5f;
        }
        if (gameObject.transform.CompareTag("Shot2"))
        {
            velocity = 0.2f;
        }
        if (gameObject.transform.CompareTag("ShotArmy"))
        {
            velocity = 0.3f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }

        gameObject.transform.position += gameObject.transform.forward * velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnemyController thisEnemyController = collision.gameObject.GetComponent<EnemyController>();

        if (thisEnemyController == null)
        {
            return;
        }

        thisEnemyController.life--;

        if (thisEnemyController.life < 0)
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
