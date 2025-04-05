using System;
using System.IO;
using UnityEngine;
using static UnityEditor.U2D.ScriptablePacker;

public class TaskData : MonoBehaviour
{
    string filepath = Application.persistentDataPath + "/" + "TaskData";

    [SerializeField]
    TaskList list;

    public void readTaskList() {
        string json = File.ReadAllText(filepath);
        list = JsonUtility.FromJson<TaskList>(json);
    }

    public void writeTaskList() {
        string json = JsonUtility.ToJson(list, true);
        File.WriteAllText(filepath,json);
    }


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
}
