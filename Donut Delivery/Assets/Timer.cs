using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLimit = 10f;
    private float checkTime;
    public Text timerText;
    private bool stop;

    // Start is called before the first frame update
    void Start()
    {
        checkTime = TimeLimit;
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkTime -= Time.deltaTime;
        if (checkTime <= 0.00f)
            stop = true;
        
        if (!stop)
            timerText.text = "Time Left: " + checkTime.ToString("n2") + " seconds";
        else
            timerText.text = "Time Left: 0.00";
        
    }
}
