using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorescript : MonoBehaviour
{
    public ballscript ballscript;
    int Score;
    //int Inningcount;
    public Text ScoreText;
    //public Text InningText;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Inningcount = ballscript.Inningcount;
        Score = ballscript.Scorecount;
        ScoreText.text = "Score:" + Score.ToString();
        //InningText.text = Inningcount.ToString() + "‰ñ";
    }
}
