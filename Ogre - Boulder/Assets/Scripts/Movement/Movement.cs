using System;
using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forwardForce, scale = 2, maxForce, minForce, minScale, maxScale;
    public Vector3 leftRotation, rightRotation;
    public GameObject dirArrow, arrowRender;

    private void Update()
    {
        MovementInputs();
    }

    private void MovementInputs()
    {
        if (Input.GetKeyDown("q"))
        {
            forwardForce += 200f;
            scale += .5f;

            if (forwardForce >= maxForce)
            {
                forwardForce = maxForce;
                scale = maxScale;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2, 2, scale);
        }

        if (Input.GetKeyDown("w"))
        {
            forwardForce -= 200f;
            scale -= .5f;
            
            if (forwardForce <= minForce)
            {
                forwardForce = minForce;
                scale = minScale;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2,2, scale);
        }

        if (Input.GetKeyDown("e"))
        {
            forwardForce += 100f;
            scale += .25f;
            
            if (forwardForce >= maxForce)
            {
                forwardForce = maxForce;
                scale = maxScale;
            }
            
            dirArrow.GetComponent<Transform>().localScale = new Vector3(2,2, scale);
        }

        if (Input.GetKeyDown("r"))
        {
            forwardForce -= 100f;
            scale -= .25f;
            
            if (forwardForce <= minForce)
            {
                forwardForce = minForce;
                scale = minScale;
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
        arrowRender.GetComponent<Renderer>().enabled = false;
        StartCoroutine(StopMovement());
    }

    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(.01f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.localEulerAngles = new Vector3(0, 0, 0);
        arrowRender.GetComponent<Renderer>().enabled = true;
    }
}