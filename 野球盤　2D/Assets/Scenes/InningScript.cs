using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InningScript : MonoBehaviour
{
    public ballscript ballscript;

    int Inningcount = 1;
    
    public Text InningText;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inningcount = ballscript.Inningcount;
        
        InningText.text = Inningcount.ToString() + "‰ñ";
    }
}
