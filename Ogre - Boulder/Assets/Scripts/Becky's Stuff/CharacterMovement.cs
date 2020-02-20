using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{

    private CharacterController controller; //used to move object
    public MovePattern Pattern;

    public void SetPattern(MovePattern pattern)
    {
        Pattern = pattern;
    }


    private void Start()
    {
        controller = GetComponent<CharacterController>(); //get component
    }

    void Update()
    {
        Pattern.Invoke(controller, transform);
    }
}