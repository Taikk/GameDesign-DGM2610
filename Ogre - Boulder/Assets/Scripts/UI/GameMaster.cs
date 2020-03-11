using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public FloatData healthAmount, healthRestart;
    private void Start()
    {
        healthAmount = healthRestart;
    }
}
