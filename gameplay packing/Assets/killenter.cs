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

    void Start()
    {
        currentweightcouter = (weightcouter)FindObjectOfType(typeof(weightcouter));
    }

    void OnTriggerEnter(Collider other)
    {
        isShowing = !isShowing;
        bar.enabled = true;
        currentweightcouter.currentweight += weight;
        Destroy(gameObject);
    }
}
