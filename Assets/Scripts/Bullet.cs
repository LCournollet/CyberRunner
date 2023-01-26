using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 50;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.right);
        // (float * float)
        // (Vector3 * float)
    }
}
