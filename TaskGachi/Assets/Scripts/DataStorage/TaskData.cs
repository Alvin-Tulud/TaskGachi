using System;
using System.IO;
using UnityEngine;
using static UnityEditor.U2D.ScriptablePacker;

/*
namespace TaskData {
    public class TaskData : MonoBehaviour
    {
        string filepath = Application.persistentDataPath + "/" + "TaskData";

        [SerializeField]
        static TaskList list;

        public void readTaskList() {
            string json = File.ReadAllText(filepath);
            list = JsonUtility.FromJson<TaskList>(json);
        }

        public void writeTaskList() {
            string json = JsonUtility.ToJson(list, true);
            File.WriteAllText(filepath,json);
        }

        public void generateExample() {
            TaskList asks = new TaskList(); // Create an array with a fixed size of 5
            asks.list = new Task[5];

            tasks.list[0] = new Task
            {
                name = "Write Documentation",
                totalSet = TimeSpan.FromHours(2),
                Time_Left = DateTime.Now.AddHours(1),
                Task_Completed = false,
                Task_Failed = false
            };

            asks.list[1] = new Task
            {
                name = "Debug Feature X",
                totalSet = TimeSpan.FromMinutes(45),
                Time_Left = DateTime.Now.AddMinutes(30),
                Task_Completed = false,
                Task_Failed = false
            };

            asks.list[2] = new Task
            {
                name = "Client Meeting",
                totalSet = TimeSpan.FromHours(1),
                Time_Left = DateTime.Now.AddHours(2),
                Task_Completed = false,
                Task_Failed = false
            };

            asks.list[3] = new Task
            {
                name = "Refactor Code",
                totalSet = TimeSpan.FromHours(3),
                Time_Left = DateTime.Now.AddHours(2.5),
                Task_Completed = false,
                Task_Failed = false
            };

            asks.list[4] = new Task
            {
                name = "Database Migration",
                totalSet = TimeSpan.FromMinutes(20),
                Time_Left = DateTime.Now.AddMinutes(10),
                Task_Completed = false,
                Task_Failed = false
            };

            TaskData.list = asks;
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

}
*/