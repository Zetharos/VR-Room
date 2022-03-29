using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hours, minutes, seconds;

    void Awake()
    {

    }

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hours.localRotation = Quaternion.Euler(30f * (float)time.TotalHours, 0f, 0f);
        minutes.localRotation = Quaternion.Euler(6f * (float)time.TotalMinutes, 0f, 0f);
        seconds.localRotation = Quaternion.Euler(6f * (float)time.TotalSeconds, 0f, 0f);
    }
}