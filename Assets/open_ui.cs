using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;



public class open_ui : MonoBehaviour
{
   public GameObject Canvasmenu_end;

    // Start is called before the first frame update
    public void  Opne_ui(){
    	Canvasmenu_end.gameObject.SetActive(true);
    }
    public void UnOpne_ui(){
    	Canvasmenu_end.gameObject.SetActive(false);
    }
   
}