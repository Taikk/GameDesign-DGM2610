using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventUpdate : MonoBehaviour
{
    public UnityEvent OnUpdateEvent;

    public void Update()
    {
        OnUpdateEvent.Invoke();
    }
}
