using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frommenutostart : MonoBehaviour
{
    public ballscript ballscript;
    public BallMove BallMove;
    // Start is called before the first frame update
    public void OnClick()
    {
        BallMove.StartMode();
       
    }
}
