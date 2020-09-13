using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class countdown : MonoBehaviour
{
    public float totalTime;
    public Text timertext;

    public Image healthBar;

    public float countTime;
    private float minutes;
    private float seconds;

    public GameObject canvasUI;
    public GameObject canvasFail;

    private void Start()
    {
        countTime = totalTime;
    }

    private void Update()
    {
        if (countTime > 0)
        {
            countTime -= Time.deltaTime;
            healthBar.fillAmount = countTime / totalTime;
            minutes = (int)(countTime / 60);
            seconds = (int)(countTime % 60);
            timertext.text = minutes.ToString() + ":" + seconds.ToString();
        }
        else { canvasUI.gameObject.SetActive(false); canvasFail.gameObject.SetActive(true); }
    }
}
