using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    protected CharacterController controller;

    public Vector3 positionDirection;
    public float speed = 10f, gravity = 3f, jumpForce = 30f;

    protected int jumpCount = 0;
    public int jumpCountMax = 2;

    public string rotateAxis = "Horizontal", zAxis = "Vertical";
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
}
