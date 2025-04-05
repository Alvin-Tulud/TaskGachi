using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TaskData : MonoBehaviour
{
    static TaskData instance;

    string filepath;

    public static TaskListData TLData;

    void Awake()
    {
        instance = this;

        filepath = Application.persistentDataPath + "/" + "TaskData";
    }

    public static TaskData GetInstance()
    {
        return instance;
    }

    public List<TaskObject> readTaskList() {
        string json = File.ReadAllText(filepath);
        TLData = JsonUtility.FromJson<TaskListData>(json);

        return TLData.list;
    }

    public void writeTaskList(List<TaskObject> list) {
        string json = JsonUtility.ToJson(list, true);
        File.WriteAllText(filepath,json);

        Debug.Log(filepath);
    }

    public void generateExample() {
        TaskListData tasks = new TaskListData();
        tasks.list = new List<TaskObject>();

        tasks.list.Add(new TaskObject
        {
            Task_Name = "Write Documentation",
            Time_TotalSet = TimeSpan.FromHours(2),
            Time_Deadline = DateTime.Now.AddHours(1),
            Task_Completed = false,
            Task_Failed = false
        });

        tasks.list.Add(new TaskObject
        {
            name = "Debug Feature X",
            Time_TotalSet = TimeSpan.FromMinutes(45),
            Time_Deadline = DateTime.Now.AddMinutes(30),
            Task_Completed = false,
            Task_Failed = false
        });

        tasks.list.Add(new TaskObject
        {
            name = "Client Meeting",
            Time_TotalSet = TimeSpan.FromHours(1),
            Time_Deadline = DateTime.Now.AddHours(2),
            Task_Completed = false,
            Task_Failed = false
        });

        tasks.list.Add(new TaskObject
        {
            name = "Refactor Code",
            Time_TotalSet = TimeSpan.FromHours(3),
            Time_Deadline = DateTime.Now.AddHours(2.5),
            Task_Completed = false,
            Task_Failed = false
        });

        tasks.list.Add(new TaskObject
        {
            name = "Database Migration",
            Time_TotalSet = TimeSpan.FromMinutes(20),
            Time_Deadline = DateTime.Now.AddMinutes(10),
            Task_Completed = false,
            Task_Failed = false
        });

        TaskData.TLData = tasks;
    }

    [Serializable]
    public struct TaskListData {
        public List<TaskObject> list;
    }
}