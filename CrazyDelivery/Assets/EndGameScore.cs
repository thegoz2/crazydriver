using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
	public Text GameSumScore;
	public float EndGameSum;
	private ScoreSys currentscorecouter;
    void Start()
    {
        currentscorecouter = (ScoreSys)FindObjectOfType(typeof(ScoreSys));
    }

    // Update is called once per frame
    void Update()
    {
        GameSumScore.text = EndGameSum.ToString() + "PO";
    }
  
}
