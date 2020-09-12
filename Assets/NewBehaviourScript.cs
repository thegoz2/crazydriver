using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Canvasmenu_end;
    public GameObject Score_hide;
    public Text timer;
    public countdown End_time;

    // Start is called before the first frame update
    void Start()
    {
        Canvasmenu_end.gameObject.SetActive(false);
        Score_hide.gameObject.SetActive(false);
        End_time = (countdown)FindObjectOfType(typeof(countdown));
    }

    
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            print("help me plssss");
            Canvasmenu_end.gameObject.SetActive(true);
            timer.text = End_time.totalTime.ToString();
        }
    }
    

}
