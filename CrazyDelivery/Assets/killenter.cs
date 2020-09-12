using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;using UnityEngine.UI;

public class killenter : MonoBehaviour
{
    public RawImage bar;
    private bool isShowing = false;
    public float weight;
    public Text weightshower;
    private weightcouter currentweightcouter;
    private ScoreSys currentscorecouter;
    public float score;
    public Text scoreshower;

    void Start()
    {
        currentweightcouter = (weightcouter)FindObjectOfType(typeof(weightcouter));
        currentscorecouter = (ScoreSys)FindObjectOfType(typeof(ScoreSys));
    }

    void OnTriggerEnter(Collider other)
    {
        isShowing = !isShowing;
        bar.enabled = true;
        currentweightcouter.currentweight += weight;
        currentscorecouter.currentscore += score;
        Destroy(gameObject);
    }
}
