using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMoveAndRotate : CharacterBehaviour
{
    protected Vector3 rotateDirection;
    public float rotateSpeed = 10f;

    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.Set(0, 0, speed * Input.GetAxis(zAxis));
            rotateDirection.y = rotateSpeed * Input.GetAxis(rotateAxis);
            transform.Rotate(rotateDirection);
            positionDirection = transform.TransformDirection(positionDirection);

            controller.Move(speed * positionDirection * Time.deltaTime);
        }
    }
}
