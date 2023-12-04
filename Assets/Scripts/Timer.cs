
using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60f;
    private bool timerRunning = false;

    private void Start()
    {
        StartTimer();
    }

    private void Update()
    {
        if (timerRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                timerRunning = false;
                GameManager.Instance.GameOver();
            }
        }
    }

    public void StartTimer()
    {
        timerRunning = true;
    }

    public void AddTime(float amount)
    {
        timeLeft += amount;
    }
}
