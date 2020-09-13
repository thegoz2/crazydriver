using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine.UI;
using UnityEngine;


namespace Assets { 
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
    public savescore savescore;

    void Start()
    {
        currentweightcouter = (weightcouter)FindObjectOfType(typeof(weightcouter));
        currentscorecouter = GameObject.FindObjectOfType<Scoresse>();
        //currentscorecouter =  GameObject.FindObjectOfType(typeof(Scoresse));
    }

    void OnTriggerEnter(Collider other)
    {
        isShowing = !isShowing;
        bar.enabled = true;
        currentweightcouter.currentweight += weight;
        Destroy(gameObject);
            savescore.sc += score;
            //currentscorecouter = (Scoresse)FindObjectOfType(typeof(Scoresse));
            //Debug.Print(currentscorecouter);
            //currentscorecouter.currentscore += score;
            //scoreshower.Text = "asd";
    }
}
}
