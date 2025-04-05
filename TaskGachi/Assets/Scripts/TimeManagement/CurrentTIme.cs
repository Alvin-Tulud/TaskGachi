using System;
using UnityEngine;

public class CurrentTIme : MonoBehaviour
{
    static DateTime now;

    void Update()
    {
        now = DateTime.Now;
    }

    public static DateTime getCurrentTime() { return now; }
}
