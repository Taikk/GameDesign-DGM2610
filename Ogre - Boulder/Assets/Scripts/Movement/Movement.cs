using System;
using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forwardForce;
    public float scale = 2;
    public Vector3 leftRotation, rightRotation;
    public GameObject dirArrow;

    private void Update()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        MovementInputs();
    }
    

    private void MovementInputs()
    {
        if (Input.GetKeyDown("q"))
        {
            forwardForce += 100f;
            scale += 1f;

            if (forwardForce >= 300)
            {
                forwardForce = 300;
                scale = 3;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2, 2, scale);
        }

        if (Input.GetKeyDown("w"))
        {
            forwardForce -= 100f;
            scale -= 1f;
            
            if (forwardForce <= 0)
            {
                forwardForce = 0;
                scale = 1;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2,2, scale);
        }

        if (Input.GetKeyDown("e"))
        {
            forwardForce += 10f;
            scale += .1f;
            
            if (forwardForce >= 300)
            {
                forwardForce = 300;
                scale = 3;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2,2, scale);
        }

        if (Input.GetKeyDown("r"))
        {
            forwardForce -= 10f;
            scale -= .1f;
            
            if (forwardForce <= 0)
            {
                forwardForce = 0;
                scale = 1;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2,2, scale);
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
        StartCoroutine(StopMovement());
    }

    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(4);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(.1f);
        transform.localEulerAngles = new Vector3(0, 0, 0);
        //ignore me
    }
}