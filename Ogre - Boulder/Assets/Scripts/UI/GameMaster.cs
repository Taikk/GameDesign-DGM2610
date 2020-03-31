using UnityEngine;
using UnityEngine.Events;

public class GameMaster : MonoBehaviour
{
    public UnityEvent StartEvent;
    private void Start()
    {
        StartEvent.Invoke();
    }
}
