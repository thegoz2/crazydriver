using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opnecavas : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject Canvasmenu_end;
   public GameObject Canvasmenu_start;
    // Start is called before the first frame update
    public void  opnecavas_Opne_ui(){
    	Canvasmenu_start.gameObject.SetActive(true);
    }
    public void opnecavas_UnOpne_ui(){
    	Canvasmenu_end.gameObject.SetActive(false);
    }
   
}
