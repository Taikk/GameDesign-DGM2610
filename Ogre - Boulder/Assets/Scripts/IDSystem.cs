using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDSystem : MonoBehaviour
{
    public List<NameID> IDNameObj;


    private void OnTriggerEnter(Collider other)
    {
        var nameIdObj = other.GetComponent<BehaviourID>().IDNameObj;
        if (nameIdObj == null) return;
        var otherNameID = nameIdObj;
        
        foreach (var ID in IDNameObj)
        {
            if (ID == otherNameID)
            {
                Debug.Log(ID);
                return;

            }
        }

    }


}