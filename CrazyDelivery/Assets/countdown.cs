using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float totalTime;
    public Text timertext;

    public float countTime;
    private float minutes;
    private float seconds;

    private void Start()
    {
        countTime = totalTime;
    }

    private void Update()
    {
        countTime -= Time.deltaTime;

        minutes = (int)(countTime / 60);
        seconds = (int)(countTime % 60);
        timertext.text = minutes.ToString() + ":" + seconds.ToString();
    }
}
