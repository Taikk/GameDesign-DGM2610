using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject playerObj;

    private void Update()
    {
        LookOrient();
    }

    public void LookOrient()
    {
        transform.LookAt(playerObj.transform.position);

        var temp = playerObj.transform.position;
        temp.x = temp.z = uint.MinValue;
        var lookRotation = Quaternion.LookRotation(temp);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);
    }
}
