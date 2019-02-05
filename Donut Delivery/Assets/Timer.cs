using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLimit = 120f;
    private float checkTime;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        checkTime = TimeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        checkTime -= Time.deltaTime;
        timerText.text = "Time Left: " + checkTime.ToString("n2") + " seconds";
    }
}
