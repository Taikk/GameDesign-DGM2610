using System.Collections;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject target;
    
    public void Update()
    {
        
        StartCoroutine(DestroyTimer());
    }
    
    private IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(2);
        Destroy(target);
    }
}
