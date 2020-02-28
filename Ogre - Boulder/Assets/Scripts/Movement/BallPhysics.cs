using System;
using System.Collections;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float ForwardForce = 0f, scale = 2;
    public Vector3 leftRotation, rightRotation;
    public GameObject dirArrow;

    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            ForwardForce += 100f;
            scale += 1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, scale, 1);
        }
        if (Input.GetKeyDown("w"))
        {
            ForwardForce -= 100f;
            scale -= 1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, scale, 1);
        }
        if (Input.GetKeyDown("e"))
        {
            ForwardForce += 10f;
            scale += .1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, scale, 1);
        }
        if (Input.GetKeyDown("r"))
        {
            ForwardForce -= 10f;
            scale -= .1f;
            dirArrow.GetComponent<Transform>().localScale = new Vector3(1, scale, 1);
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
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, ForwardForce);
        StartCoroutine(stopMovement());
    }

    IEnumerator stopMovement()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(.01f);
        transform.localEulerAngles = new Vector3 (0, 0, 0);
    }
}