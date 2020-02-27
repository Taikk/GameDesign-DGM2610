using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public GameObject player;

    public Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
