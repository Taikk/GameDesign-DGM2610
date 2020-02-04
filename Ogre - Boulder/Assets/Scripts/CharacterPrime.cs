using UnityEngine;
[CreateAssetMenu]
public class CharacterPrime : CharacterBase
{
    public override void Move()
    {
        Location.Set(Input.GetAxis("Vertical")*speed,0,0 );
        Orientation.y = Input.GetAxis("Horizontal")*orientSpeed;
        
        Controller.transform.Rotate(Orientation);
        Location = Controller.transform.TransformDirection(Location);
        
        Controller.Move(Location * Time.deltaTime);
    }
}