using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject prefabDoTiro;
    public float fireRate = 0.5f;

    float fireTime;

    // Update is called once per frame
    void Update()
    {
        fireTime += Time.deltaTime;

        if (fireTime > fireRate)
        {
            if(Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) {
                fireTime = 0;
                Instantiate(prefabDoTiro, gameObject.transform.position, gameObject.transform.rotation);
            }
        }
    }
}
