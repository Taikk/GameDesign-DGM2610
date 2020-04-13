﻿using System.Collections;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    public float movement, scale, maxValue, minValue, maxScale, minScale;
    public Transform dirArrow;
    public GameObject arrowRender;
    
    private void Update()
    {
        ForceStrength();

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Click");
            GetComponent<Rigidbody>().AddRelativeForce(0f,0f,movement);
            arrowRender.GetComponent<Renderer>().enabled = false;
            StartCoroutine(StopMovement());
        }
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(hit.point);
        }
    }

    private void ForceStrength()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q Pressed");
            movement += 200f;
                scale += 0.5f;
                if (movement >= maxValue)
                {
                    movement = maxValue;
                    scale = maxScale;
                }

                dirArrow.localScale = new Vector3(2, 2, scale);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement -= 200f;
            scale -= 0.5f;

            if (movement <= minValue)
            {
                movement = minValue;
                scale = minValue;
            }

            dirArrow.localScale = new Vector3(2, 2, scale);
        }
    }
    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(4);
        arrowRender.GetComponent<Renderer>().enabled = true;
    }

}