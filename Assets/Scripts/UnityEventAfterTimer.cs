using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class UnityEventAfterTimer : MonoBehaviour
{
    public UnityEvent onTimerCompleted;

    private bool timerRunning = false;
    [SerializeField] private float timerLength = 30f;
    private float defaultTime;

    public TextMeshProUGUI timerValueUI;
    private bool displayText = false;

    private void Start()
    {
        defaultTime = timerLength;

        if (timerValueUI != null)
        {
            displayText = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            timerLength -= Time.deltaTime;
            Debug.Log($"Time left: {(int)timerLength}");

            if (displayText)
            {
                timerValueUI.SetText($"You're done, now he wants you back. You'll have to wait {(int)timerLength} seconds until he lets you go back. :)");
            }

            if (timerLength <= 0f)
            {
                onTimerCompleted.Invoke();
                timerRunning = false;
                timerLength = defaultTime;
            }
        }
    }

    public void StartTimer()
    {
        timerRunning = true;
    }
}
