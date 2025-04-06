using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.Notifications.Android;
using System;

public class NotificationManager : MonoBehaviour
{
    public AndroidNotificationChannel channel;

    private int identifier;

    private void Start() 
    {
        channel = new AndroidNotificationChannel()
        {
            Id = "dachi_channel",
            Name = "Dachi Channel",
            Description = "Tomodachi notifications",
            Importance = Importance.Default,
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        AndroidNotification notification = new AndroidNotification()
        {
            Title = "Your Dachi tests you!",
            Text = "Hi, welcome to the app :3",
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = System.DateTime.Now.AddSeconds(10),
        };

        identifier = AndroidNotificationCenter.SendNotification(notification, "dachi_channel");
    }

    public void TaskNotification(System.DateTime deadline)
    {
        DateTime notifyTime = deadline.AddHours(-1);

        if (notifyTime < DateTime.Now) { return; }

        AndroidNotification notification = new AndroidNotification()
        {
            Title = "Your Dachi beckons you!",
            Text = "Come back pwease, one of your tasks is nearly up :3",
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = notifyTime,
        };

        identifier = AndroidNotificationCenter.SendNotification(notification, "dachi_channel");
    }

    public void TestTaskNotification(System.DateTime deadline)
    {
        DateTime notifyTime = deadline.AddSeconds(-15);

        if (notifyTime < DateTime.Now) { return; }

        AndroidNotification notification = new AndroidNotification()
        {
            Title = "Your Dachi beckons you!",
            Text = "Come back pwease, one of your tasks is nearly up :3",
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = notifyTime,
        };

        identifier = AndroidNotificationCenter.SendNotification(notification, "dachi_channel");
    }
}
