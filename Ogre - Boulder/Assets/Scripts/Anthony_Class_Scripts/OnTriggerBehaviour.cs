using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class OnTriggerBehaviour : MonoBehaviour
{
    public UnityEvent Event;
    public UnityEvent<Collider> colliderEvent;

    private void OnTriggerEnter(Collider other)
    {
        //Event.AddListener(null);
        //ColliderEvent.Invoke(other);
        Event.Invoke();
    }
}