using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/Booldata")]
public class BoolData : ScriptableObject
{
    public bool value;

    public void setBool(bool dataObj)
    {
        dataObj = false;
        if (dataObj == true)
        {
            value = true;
        }
        else
        {
            value = false;
        }
    }
}
