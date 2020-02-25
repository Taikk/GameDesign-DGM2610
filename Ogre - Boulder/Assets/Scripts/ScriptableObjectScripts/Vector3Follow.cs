using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Follow : ScriptableObject
{
    public Vector3 location;

    public void UpdateData(Transform objTransform)
    {
        location = objTransform.position;
    }
}
