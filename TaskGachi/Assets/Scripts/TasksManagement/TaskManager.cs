using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    private List<TaskObject> TaskList = new List<TaskObject>();
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void addTask(TaskObject obj)
    {
        TaskList.Add(obj);
    }
}
