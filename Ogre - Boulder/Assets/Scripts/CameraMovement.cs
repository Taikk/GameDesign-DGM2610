using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform LookAt, camTransform;

    private Camera cam;

    private const float yAngleMin = 0.0f, yAngleMax = 50.0f;

    [SerializeField] private float distance = 10f, currentX = 0f, currentY = 0f, sensitivityX = 4f, sensitivityY = 1f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, yAngleMin, yAngleMax);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0,0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = LookAt.position + rotation * dir;
        camTransform.LookAt(LookAt.position);
    }
    
}