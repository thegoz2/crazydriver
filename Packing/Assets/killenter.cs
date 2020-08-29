using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class killenter : MonoBehaviour
{
    public RawImage bar;
    private bool isShowing = false;

    void OnTriggerEnter(Collider other)
    {
        isShowing = !isShowing;
        bar.enabled = true;
        Destroy(gameObject);
    }
}
