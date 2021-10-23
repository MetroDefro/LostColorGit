using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public Text clearTimeText;
    public Button start;
    public Button stop;
    public Image clearImg;
    public float timer;
    private float startTime;
    bool keepTiming;
    int minute = 0;
    int second = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop.gameObject.activeSelf == false)
        {
            Time.timeScale = 0;
        }
        if (stop.gameObject.activeSelf == true)
        {
            Time.timeScale = 1;
            keepTiming = true;
        }
        

        if (keepTiming)
        {
            UpdateTime();
        }
    }
    void UpdateTime()
    {
        timer = Time.time - startTime;
        timeText.text = TimeToString(timer);
        clearTimeText.text = TimeToString(timer);
    }

    float StopTimer()
    {
        keepTiming = false;
        return timer;
    }

    void ResumeTimer()
    {
        keepTiming = true;
        startTime = Time.time - timer;
    }

    void StartTimer()
    {
        keepTiming = true;
        startTime = Time.time;
    }

    public string TimeToString(float t)
    {
        string minutes = ((int)t / 60).ToString();
        string seconds = ((int)t % 60).ToString();
        return minutes + " : " + seconds;
    }

}
