using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public float nextFire = 0.5f;
    public float fireRate = 0.0f, forceAmnt;

    public GameObject prefabObj;
    public Rigidbody rb;

    public void Start() => ObjectInstance();

    private void ObjectInstance()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            Instantiate(prefabObj, transform.position, transform.rotation);
        }
    }
}
