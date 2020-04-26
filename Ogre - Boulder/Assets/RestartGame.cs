using System;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public FloatData healthAmount;

    private void Update()
    {
        if (healthAmount.value <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
