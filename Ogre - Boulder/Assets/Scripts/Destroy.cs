using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject target;

    public void DestroyObj()
    {
        target.SetActive(false);
    }
}
