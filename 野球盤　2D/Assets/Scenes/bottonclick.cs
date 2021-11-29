using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottonclick : MonoBehaviour
{
    public ballscript ballscript;
    // Start is called before the first frame update
    public void OnClick()
    {
        ballscript.SettingMode();
    }

    
}
