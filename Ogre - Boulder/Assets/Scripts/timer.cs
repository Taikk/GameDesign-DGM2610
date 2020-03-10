using System;
using System.Collections;
using UnityEngine;

public class timer : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyNumerator());
    } 
    
    private IEnumerator DestroyNumerator()
    {
        Debug.Log("Before");
        yield return new WaitForSeconds(3f);
        Debug.Log("After");
        Destroy(gameObject);
    }
}
