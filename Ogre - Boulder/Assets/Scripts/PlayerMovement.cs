using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Speed Attributes")]
    public float speed = 3.5f;
    void Update()
    {
        MovementCalc(); //Update on movement
    }

    private void MovementCalc()
    {
        //grab the input axis for horizontal and vertical movement in unity physics
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * horizontalInput * speed * Vector3.right);
        transform.Translate(Time.deltaTime * verticalInput * speed * Vector3.up);

    }
}