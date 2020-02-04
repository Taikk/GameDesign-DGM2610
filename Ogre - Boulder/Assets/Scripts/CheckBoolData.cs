using System;
using UnityEngine;


public class CheckBoolData : MonoBehaviour
{
    public BoolData boolDataObj;

    void Update()
    {
        if (boolDataObj.value)
        {
            print(true);
            //true work
        }
        else
        {
            //false work
        }
    }
}
