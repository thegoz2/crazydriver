using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Canvasmenu_end;

    // Start is called before the first frame update
    void Start()
    {
        Canvasmenu_end.gameObject.SetActive(false);
    }

    
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            print("help me plssss");
            Canvasmenu_end.gameObject.SetActive(true);
        }
    }
    

}
