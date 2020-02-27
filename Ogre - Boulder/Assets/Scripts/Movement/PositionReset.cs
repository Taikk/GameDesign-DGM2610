using UnityEngine;

public class PositionReset : MonoBehaviour
{
    public float ResetZone;

    public Rigidbody rb;

    public Vector3Data objectData;

    private void Update()
    {
        if (transform.position.y <= ResetZone)
        {
            transform.position = objectData.dataobj;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
