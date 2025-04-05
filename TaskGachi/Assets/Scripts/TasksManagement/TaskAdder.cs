using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskAdder : MonoBehaviour
{
    public TaskManager task_manager;

    public TMP_InputField ItaskName;
    public TMP_Dropdown DtaskDays;
    public TMP_Dropdown DtaskHours;
    public TMP_Dropdown DtaskMinutes;

    public void AddTask()
    {

    }

    //creates a task given and name and days hours and minutes needed
    public void CreateTask()
    {
        TaskObject TObj = ScriptableObject.CreateInstance<TaskObject>();
        string TaskName;
        int days, hours, minutes;


        TaskName = ItaskName.text;
        days = DtaskDays.value;
        hours = DtaskHours.value;
        minutes = DtaskMinutes.value;


        //create new task object
        TObj = new TaskObject();
        //set name
        TObj.Task_Name = TaskName;

        //create timespan for time inputted
        TimeSpan timeset = new TimeSpan(days, hours, minutes, 0);
        //set that to total time given on object
        TObj.Time_TotalSet = timeset;

        //get the future time the task will be done at
        DateTime FutureTime = CurrentTIme.getCurrentTime() + timeset;
        //get value of how much time is left
        TObj.Time_Deadline = FutureTime;

        //set completion states to false
        TObj.Task_Completed = false;
        TObj.Task_Failed = false;

        //send task object to taskmanager script
        task_manager.addTask(TObj);
    }
}
