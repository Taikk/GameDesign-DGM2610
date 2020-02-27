using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float ForwardForce = 0f;

    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            ForwardForce += 100f;
        }
        if (Input.GetKeyDown("w"))
        {
            ForwardForce -= 100f;
        }
        if (Input.GetKeyDown("e"))
        {
            ForwardForce += 10f;
        }
        if (Input.GetKeyDown("r"))
        {
            ForwardForce -= 10f;
        }
    }

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, ForwardForce);
    }

}