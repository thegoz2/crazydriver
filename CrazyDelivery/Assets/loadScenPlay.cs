using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadScenPlay : MonoBehaviour
{
    // Start is called before the first frame update
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/Scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
        
    }

    public void loadnow()
    {
        SceneManager.LoadScene("map_stage");
    }


}
