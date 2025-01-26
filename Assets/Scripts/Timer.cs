using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshPro timerText;
    public bool isLose;
    private void Update()
    {
        if (isLose == false)
        {
            timer += Time.deltaTime;
        }
        timerText.text = timer.ToString("0.0");
    }
}
