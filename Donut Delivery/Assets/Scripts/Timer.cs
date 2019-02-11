﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLimit = 10f;
    private float checkTime;
    public int houses;
    public Text timerText;
    public Text message;
    public Text counter;
    private bool stop;

    // Start is called before the first frame update
    void Start()
    {
        checkTime = TimeLimit;
        stop = false;
        houses = 0;
        counter.text = "Donuts Delivered: " + houses;
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "Donuts Delivered: " + houses;
        checkTime -= Time.deltaTime;

        //Text will change to yellow when timer < 50% and to red when timer < 20%
        if (checkTime <= (TimeLimit * 0.5f) && checkTime > (TimeLimit * 0.20f))
            timerText.color = Color.yellow;
        
        if (checkTime <= (TimeLimit * 0.20f))
            timerText.color = Color.red;
        

        if (checkTime <= 0.00f)
        {
            stop = true;
            message.text = "Time's Up! Try Again? \n       Press Space";

            //press spacebar to restart level
            if (Input.GetKey(KeyCode.Space))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
            
        
        if (!stop)
            timerText.text = "Time Left: " + checkTime.ToString("n2") + " seconds";
        else
            timerText.text = "Time Left: 0.00";
        
    }
}
