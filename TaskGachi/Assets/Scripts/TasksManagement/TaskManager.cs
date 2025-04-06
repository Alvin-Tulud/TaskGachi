using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

    public class TaskManager : MonoBehaviour
    {
        private List<TaskObject> TaskList = new List<TaskObject>();

        TaskData Tdata;
        private void Start()
        {
            Tdata = TaskData.GetInstance();

            try
            { 
                TaskList = Tdata.readTaskList();
            }
            catch (Exception e) 
            { 
                Debug.Log("No Data Found"); 
                Debug.Log(e);
            }
        }

        private void OnApplicationQuit()
        {
            Tdata.writeTaskList(TaskList);
        }

        public void addTask(TaskObject obj)
        {
            TaskList.Add(obj);
        }

        public List<TaskObject> getList() 
        {
            return TaskList;
        }

        public void setList(List<TaskObject> tasklist)
        {
            TaskList = tasklist;
        }
    }
