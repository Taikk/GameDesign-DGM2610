using UnityEngine;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float moveSpeed = 0f, jumpSpeed = 0f, gravity = 9.81f, rotationSpeed = 60f;

    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        
        moveDirection.y -= gravity * Time.deltaTime; //Gravity Effects
        
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical")); //movement controls
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;

            if (Input.GetButton("Jump")) //checking for input of jump button
                moveDirection.y = jumpSpeed;
            
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed, 0); //Player Rotation
        
        controller.Move(moveDirection * Time.deltaTime); //frame rate
    }
}
