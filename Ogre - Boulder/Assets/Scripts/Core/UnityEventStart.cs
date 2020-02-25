using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventStart : MonoBehaviour
{
    public UnityEvent EventStart;

    void Start()
    {
        EventStart.Invoke();
    }
}