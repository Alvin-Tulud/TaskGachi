using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Hierarchy;

public class TaskDisplay : MonoBehaviour
{
    // Set to the game object representing the tasks
    public GameObject taskObject;
    // Where the Tasks will appear
    public GameObject canvas;
    // To access the tasks
    private TaskManager manae;

    private Transform firstTaskLocation;
    private float offset = 20.0F;
    private int numberOfTasks;

    public void showTasks() {
        // 1. Spawn all tasks currently stored in the TaskManager
        //List<TaskObject> taskList = manae.getList();
        //numberOfTasks = taskList.Count;

        for (int i = 0; i < 10; i++) {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y - (i * offset));
            
            GameObject spawnedObject = Instantiate(taskObject, spawnPosition, Quaternion.identity);
            
            spawnedObject.transform.SetParent(canvas.transform);
            spawnedObject.SetActive(true);

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
