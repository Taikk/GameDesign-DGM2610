using UnityEngine;
using UnityEngine.Events;

public class BehaviourID : MonoBehaviour
{
    public NameID nameIdObj;
    public UnityEvent EnterEvent, ExitEvent;
    
    public void EnterTrigger()
    {
        EnterEvent.Invoke();

    }

    public void ExitTrigger()
    {
        ExitEvent.Invoke();
    }
    
}