using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class Scoresse : MonoBehaviour
{
    public Text scoretext;
    public float currentscore;

    void Update()
    {
        scoretext.text = currentscore.ToString() + "PO";
    }
}
