using System.Collections;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    public float movement, scale, maxValue, minValue, maxScale, minScale, forceAdd;
    public Transform dirArrow;
    public GameObject arrowRender;

    private void Update()
    {
        ForceStrength();
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0f, 0f, movement);
            arrowRender.GetComponent<Renderer>().enabled = false;
            StartCoroutine(StopMovement());
        }

        RaycastHit hit;
        var ray = Camera.current.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(hit.point);
        }
    }

    private void ForceStrength()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            movement += forceAdd;
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
            movement -= forceAdd;
            scale -= 0.5f;
            if (movement <= minValue)
            {
                movement = minValue;
                scale = minScale;
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