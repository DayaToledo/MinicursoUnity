using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRandom : MonoBehaviour
{
    float timer = 0;
    float force = 180;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = Random.Range(0.5f, 1);

            gameObject.GetComponent<BoxCollider>().attachedRigidbody.AddForce(Vector3.up * force);
        }
    }
}
