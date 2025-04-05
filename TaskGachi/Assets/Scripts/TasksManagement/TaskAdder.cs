using System;
using UnityEngine;

public class TaskAdder : MonoBehaviour
{
    public TaskObject object_to_make;

    public TaskManager task_manager;

    //creates a task given and name and days hours and minutes needed
    public void CreateTask(string TaskName, int days, int hours, int minutes)
    {
        //create new task object
        object_to_make = new TaskObject();
        //set name
        object_to_make.Task_Name = TaskName;

        //create timespan for time inputted
        TimeSpan timeset = new TimeSpan(days, hours, minutes, 0);
        //set that to total time given on object
        object_to_make.Time_TotalSet = timeset;

        //get the future time the task will be done at
        DateTime FutureTime = CurrentTIme.getCurrentTime() + timeset;
        //get value of how much time is left
        object_to_make.Time_Deadline = FutureTime;

        //set completion states to false
        object_to_make.Task_Completed = false;
        object_to_make.Task_Failed = false;

        //send task object to taskmanager script
        task_manager.addTask(object_to_make);
    }
}
