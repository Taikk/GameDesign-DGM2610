using UnityEngine;
using UnityEngine.Events;

public class MonoBehaviours : MonoBehaviour
{
public UnityEvent awakeEvent, startEvent, quitEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnApplicationQuit()
    {
        quitEvent.Invoke();
    }
}