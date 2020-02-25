using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Multiple Variables/Transforms")]
public class Transformer : ScriptableObject
{
    [SerializeField]
    public GameObject Player;
    public GameObject Trigger;
    
    private void Update() 
    { 
        Player.transform.position = Trigger.transform.position;
    }
}
