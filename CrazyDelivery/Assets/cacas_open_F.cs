using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cacas_open_F : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject Canvasmenu_end;
   public GameObject Canvasmenu_start;
    // Start is called before the first frame update
    public void  Opne_ui(){
    	Canvasmenu_start.gameObject.SetActive(true);
    }
    public void UnOpne_ui(){
    	Canvasmenu_end.gameObject.SetActive(false);
    }
   
}
