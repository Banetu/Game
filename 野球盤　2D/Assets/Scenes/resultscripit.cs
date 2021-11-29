using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class resultscripit : MonoBehaviour
{
    public ballscript ballscript;

    public static int Scorecount = 0;

    public Text ResultText;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scorecount = ballscript.Scorecount;

        ResultText.text = "Your Score:" + Scorecount.ToString();
    }
}
