using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class FloatInput : FloatData
{

    public string InputType;

    public override float Value //override the other value of its parent 
    {
        get { return Input.GetAxis(InputType) * value; } //returns on axses the input type of our choice.
    }

}