using System;
using UnityEngine;
using static UnityEditor.U2D.ScriptablePacker;

[Serializable]
public struct Task {
    public string name;
    public TimeSpan totalSet;
    public DateTime Time_Left;
    public bool Task_Completed;
    public bool Task_Failed;
}


[Serializable]
public struct TaskList {
    public Task[] list;
}

public class TaskData : MonoBehaviour
{
    string filepath = Application.persistentDataPath + "/" + "TaskData";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
