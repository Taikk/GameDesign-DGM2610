﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionTransformer : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(0,0,0);
    }
}
