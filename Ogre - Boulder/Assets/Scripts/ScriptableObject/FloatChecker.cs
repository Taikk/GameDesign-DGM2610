using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variables/FloatChecker")]
public class FloatChecker : ScriptableObject
{
    public FloatData floatDataObj;

    public UnityEvent equalEvent;

    public void CheckFloatData(FloatData other)
    {
        if (floatDataObj.value == other.value)
        {
            equalEvent.Invoke();
        }
    }
}
