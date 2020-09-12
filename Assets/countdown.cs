using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float totalTime;
    public Text timertext;

    private float minutes;
    private float seconds;


    private void Update()
    {
        totalTime -= Time.deltaTime;

        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);
        timertext.text = minutes.ToString() + ":" + seconds.ToString();
    }
}
