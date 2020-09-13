using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class changeui : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject pic1;
   public GameObject pic2;
   private int times = 1;
    // Start is called before the first frame update
    public void  firstclick(){
        if (times == 1){
            pic1.gameObject.SetActive(true);
            pic2.gameObject.SetActive(false);
            }
        if (times == 2){
            pic1.gameObject.SetActive(false);
            pic2.gameObject.SetActive(true);
        }
        times += 1;
        if (times >= 3){
            times = 1;
        }
        
}
}