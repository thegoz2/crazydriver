using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load_AtStart : MonoBehaviour
{
    // Start is called before the first frame update
    public int Go_to;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        //myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/Scenes");
        //scenePaths = myLoadedAssetBundle.GetAllScenePaths();

    }

    public void loadnow()
    {
        if (Go_to == 1) { SceneManager.LoadScene("map_stage"); }
        else if (Go_to == 3) { Application.Quit(); }
        else if (Go_to == 2) { SceneManager.LoadScene("map_select-stage"); }
        else if (Go_to == 4) { SceneManager.LoadScene("map_start"); }
    }

}
