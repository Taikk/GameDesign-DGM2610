using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSO : MonoBehaviour
{
    public void LookDirection(Vector3Follow info)
    {
        transform.LookAt(info.location);
    }
}
