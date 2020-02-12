using System;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{
    public NameID ID;
    public UnityEvent OnMatch, NoMatch;
    public bool MatchMade { private get; set; }

    private void OnParticleTrigger(Collider other)
    {
        var otherId = other.GetComponent<MatchID>();
        if (otherId == null) return;

        if (otherId.ID == ID || otherId.MatchMade)
        {
            OnMatch.Invoke();
        }
        else
        {
            NoMatch.Invoke();
        }
    }
}
