using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/DestroySO")]
public class DestroySO : ScriptableObject
{
    public void DestroyObj(GameObject other)
    {
        Destroy(other);
    }
}
