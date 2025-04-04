using System;
using UnityEngine;

public class TaskAdder : MonoBehaviour
{
    public TaskObject object_to_make;

    public TaskManager task_manager;

    public void CreateTask(string TaskName, DateTime TotalTime)
    {
        object_to_make = new TaskObject();
        object_to_make.Task_Name = TaskName;
        object_to_make.Time_TotalSet = TotalTime;

        DateTime SubtractTime = CurrentTIme.getCurrentTime().Add(TotalTime);

        object_to_make.Time_Left = 
    }
}
