using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    public float velocity = 0.1f;
    public float lifeTime = 3;

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
