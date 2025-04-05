using System;
using UnityEngine;

[Serializable]
public struct GachiStats {
    public int health;
    public string spritePath;
}


public class GachiData : MonoBehaviour
{


    string filepath = Application.persistentDataPath + "/" + "GachiData";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
