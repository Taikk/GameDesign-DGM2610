using UnityEngine;

public class positionTransformer : MonoBehaviour
{
    public float areaOfEffect;
    public Rigidbody rigidbody;
    public Vector3Data dataObj;

    private void Update()
    {
        if (transform.position.y <= areaOfEffect)
        {
            transform.position = dataObj.dataobj;
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}