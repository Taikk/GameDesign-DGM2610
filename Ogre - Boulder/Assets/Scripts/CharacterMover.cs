using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float moveSpeed = 0f, jumpSpeed = 0f, gravity = 9.81f, rotationSpeed = 10f;

    private Vector3 position;// rotation;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.Set(Input.GetAxis("Horizontal") * moveSpeed, 0, Input.GetAxis("Vertical") * moveSpeed);
        //rotation.y = rotationSpeed * Input.GetAxis("Horizontal");
        //controller.transform.Rotate(rotation);

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                position.y = jumpSpeed;
            }
        }

        if (position != Vector3.zero)
        {
            controller.transform.forward = position;
        }

        position.y -= gravity * Time.deltaTime;
        controller.Move(position * Time.deltaTime);
        

    }
}
