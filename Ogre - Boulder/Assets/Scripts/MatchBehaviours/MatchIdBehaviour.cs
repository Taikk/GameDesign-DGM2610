using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class MatchIdBehaviour : IdBehaviour
{
    [Serializable] 
    public struct possibleMatch
    {
        public NameId nameIdObj;
        public UnityEvent enterEvent, stayEvent;
    }
    
    public List<possibleMatch> nameIdList;
    [SerializeField]
    public Dictionary<NameId, UnityEvent> nameIdDictionary;
    private IdBehaviour otherBehaviourObj;
    private NameId otherIdObj;
   
    private void OnTriggerEnter(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IdBehaviour>();
        if ( otherBehaviourObj == null) return;
        
        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckId(1);
    }
    
    private void OnTriggerStay(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IdBehaviour>();
        if ( otherBehaviourObj == null) return;
        
        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckId(2);
    }

    private void CheckId(int other)
    {
        foreach (var obj in nameIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                switch (other)
                {
                    case 1:
                        obj.enterEvent.Invoke();
                        break;
                    case 2:
                        obj.stayEvent.Invoke();
                        break;
                    default:
                        return;
                }
            }
        }
    }
    
}
