using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSys : MonoBehaviour
{
    public Text scoretext;
    public float currentscore;
    void Update()
    {
        scoretext.text = currentscore.ToString() + "PO";
    }
}
