using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBottonclick : MonoBehaviour
{
    // Start is called before the first frame update
    public BallMove BallMove;
    // Start is called before the first frame update
    public void OnClick()
    {
        BallMove.GameMenu();
    }
}
