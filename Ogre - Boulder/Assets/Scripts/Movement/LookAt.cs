using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LookAt : MonoBehaviour
{
    [Serializable]
    public struct possibleMatch
    {
        public NameId nameIdObj;
    }

    public List<possibleMatch> nameIdList;

    public GameObject playerObj;
    private IdBehaviour otherBehaviourObj;
    private NameId otherIdObj;

    private void Update()
    {
        if (playerObj)
        {
            LookOrient();
        }
    }

    public void LookOrient()
    {
        transform.LookAt(playerObj.transform.position);

        var temp = playerObj.transform.position;
        temp.x = temp.z = uint.MinValue;
        var lookRotation = Quaternion.LookRotation(temp);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IdBehaviour>();
        if (otherBehaviourObj == null) return;

        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckId(1);
    }

    private void OnTriggerExit(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IdBehaviour>();
        if (otherBehaviourObj == null) return;

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
                        playerObj = otherBehaviourObj.gameObject;
                        break;
                    case 2:
                        playerObj = null;
                        break;
                }

            }
        }
    }
}