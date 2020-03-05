using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool trig;
    public float radius;

    public float nextFire, fireRate;

    public GameObject projectilePreFab;
    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public void AttackTrigger()
    {
        trig = true;
        AttackTarget();
    }

    private void AttackTarget()
    {
        if (trig == true && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(projectilePreFab, transform.position + new Vector3(0, .8f, 0), Quaternion.identity);
            Debug.Log(("Throw Object"));
        }
    }
}