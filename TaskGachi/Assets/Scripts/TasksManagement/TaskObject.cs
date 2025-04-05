using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Tasks", menuName = "Tasks/TaskObject", order = 1)]
public class TaskObject : ScriptableObject
{
    public string Task_Name;

    public TimeSpan Time_TotalSet;
    public TimeSpan Time_Left;

    public bool Task_Completed = false;
    public bool Task_Failed = false;
}
