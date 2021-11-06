using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensibility = 3;

    float mouseScrollDelta = 0;

    // Update is called once per frame
    void Update()
    {
        mouseScrollDelta = Input.GetAxis("Mouse X");

        mouseScrollDelta *= sensibility;

        transform.Rotate(Vector3.up, mouseScrollDelta);
    }
}
