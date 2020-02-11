using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionTransformer : MonoBehaviour
{
    public float areaOfEffect;
    public Rigidbody rigidbody;

    private void Update()
    {
        if (transform.position.y <= areaOfEffect)
        {
            transform.position = new Vector3(51, 7.5f, -57.5f);
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}