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
    private Scoresse currentscorecouter;
    public float score;
    public Text scoreshower;

    void Start()
    {
        currentweightcouter = (weightcouter)FindObjectOfType(typeof(weightcouter));
        currentscorecouter = (Scoresse)FindObjectOfType(typeof(Scoresse));
    }

    void OnTriggerEnter(Collider other)
    {
        isShowing = !isShowing;
        bar.enabled = true;
        currentweightcouter.currentweight += weight;
        Destroy(gameObject);
        currentscorecouter.currentscore += score;
    }
}
