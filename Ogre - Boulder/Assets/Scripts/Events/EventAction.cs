using UnityEngine;
using UnityEngine.Events;

public class EventAction : MonoBehaviour
{
    public UnityEvent StartEvent, UpdateEvent, StopEvent;

    void Start()
    {
        StartEvent.Invoke();
        UpdateEvent.Invoke();
        StopEvent.Invoke();
    }
}
