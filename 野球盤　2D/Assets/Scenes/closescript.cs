using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closescript : MonoBehaviour
{
    public ballscript ballscript;
    public BallMove BallMove;

    // Start is called before the first frame update
    public void OnClick()
    {
        if(BallMove.Status == 1)
        {
            ballscript.Backtostart();
        }
        

        else
            ballscript.PlayMode();
    }


}
