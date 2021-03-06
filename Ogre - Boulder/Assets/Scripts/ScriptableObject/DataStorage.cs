﻿using UnityEngine;

[CreateAssetMenu(fileName = "DataStorage", menuName = "Data Storage/Data Storage Object")]

public class DataStorage : ScriptableObject
{
    public ScriptableObject data;

    public void SetData()
    {
        if (data == null) return;
        PlayerPrefs.SetString(data.name, JsonUtility.ToJson(data));
    }

    public void Getdata()
    {
        if (data == null) return;
        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(data.name)))
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(data.name), data);
    }
}