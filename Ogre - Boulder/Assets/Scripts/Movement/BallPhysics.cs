using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class BallPhysics : MonoBehaviour
{
    public float forwardForce = 0f;
    public float scale = 2;
    public Vector3 leftRotation, rightRotation;
    public GameObject dirArrow;

    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            forwardForce += 100f;
            scale += 1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, 1, scale);
        }
        if (Input.GetKeyDown("w"))
        {
            forwardForce -= 100f;
            scale -= 1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, 1, scale);
        }
        if (Input.GetKeyDown("e"))
        {
            forwardForce += 10f;
            scale += .1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, 1, scale);
        }
        if (Input.GetKeyDown("r"))
        {
            forwardForce -= 10f;
            scale -= .1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, 1, scale);
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(leftRotation);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(rightRotation);
        }
    }

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, forwardForce);
        StartCoroutine(stopMovement());
    }

    IEnumerator stopMovement()
    {
        yield return new WaitForSeconds(4);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(.1f);
        transform.localEulerAngles = new Vector3 (0, 0, 0);
    }
}