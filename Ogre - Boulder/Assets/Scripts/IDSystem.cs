using System.Collections.Generic;
using UnityEngine;
public class IDSystem : MonoBehaviour
{
    public List<NameID> IDNameObj;

    private void OnTriggerEnter(Collider other)
    {
        var nameIdObj = other.GetComponent<BehaviourID>();
        if (nameIdObj == null) return;
        var otherNameID = nameIdObj.IDNameObj;
        
        foreach (var ID in IDNameObj)
        {
            if (ID == otherNameID)
            {
                nameIdObj.EnterTrigger();
                return;
            }
        }
    }
}