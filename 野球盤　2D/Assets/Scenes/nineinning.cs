using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nineinning : MonoBehaviour
{
    public ballscript ballscript;
    public BallMove BallMove;
    // Start is called before the first frame update
    public void OnClick()
    {
        BallMove.Gamestart();
        ballscript.EndInning = 9;
    }
}
