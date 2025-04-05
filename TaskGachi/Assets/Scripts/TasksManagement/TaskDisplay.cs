using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TaskDisplay : MonoBehaviour
{
    // Set to the game object representing the tasks
    public GameObject taskObject;
    // To access the tasks
    private TaskManager manae;

    private Transform firstTaskLocation;
    private float offset = 4.0F;
    private int numberOfTasks;

    public void showTasks() {
        // 1. Spawn all tasks currently stored in the TaskManager
        List<TaskObject> taskList = manae.getList();
        numberOfTasks = taskList.Count;

        for (int i = 0; i < numberOfTasks; i++) {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + (i * offset));
            
            GameObject spawnedObject = Instantiate(taskObject, spawnPosition, Quaternion.identity);
            
            spawnedObject.transform.parent = transform;

        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manae = GetComponent<TaskManager>();

        showTasks();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            
        }

        if (Input.GetKey(KeyCode.S)) {
            showTasks();
        }
    }
}
