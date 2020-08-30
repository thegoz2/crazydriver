using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weightcouter : MonoBehaviour
{
    public float currentweight;
    public Text weightshow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weightshow.text = currentweight.ToString() + "kg";
    }
}
