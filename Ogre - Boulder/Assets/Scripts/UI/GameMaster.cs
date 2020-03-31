using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.WSA.Input;

public class GameMaster : MonoBehaviour
{
    public UnityEvent StartEvent;
    private void Start()
    {
        StartEvent.Invoke();
    }
}
