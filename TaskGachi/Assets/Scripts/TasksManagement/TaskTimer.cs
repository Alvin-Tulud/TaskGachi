using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTimer : MonoBehaviour
{
    private bool canCheckTaskTime;
    private TaskManager manager;

    void Start()
    {
        manager = GetComponent<TaskManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canCheckTaskTime)
        {
            StartCoroutine(checkTaskTime());
        }
    }

    IEnumerator checkTaskTime()
    {
        canCheckTaskTime = false;

        List<TaskObject> tasklist = new List<TaskObject>();

        tasklist = manager.getList();

        foreach (TaskObject task in tasklist)
        {
            if (DateTime.Compare(task.Time_Deadline,CurrentTIme.getCurrentTime()) > 0)
            {
                task.Task_Failed = true;
            }
        }

        manager.setList(tasklist);

        yield return new WaitForSeconds(30);

        canCheckTaskTime = true;
    }
}
