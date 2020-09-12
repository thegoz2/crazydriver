using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;



public class UI_Opne : MonoBehaviour
{
	public GameObject Canvasmenu_end;
    // Start is called before the first frame update
    public void  Opne(){
    	Canvasmenu_end.gameObject.SetActive(true);
    }
    public void UnOpne(){
    	Canvasmenu_end.gameObject.SetActive(false);
    }
}

