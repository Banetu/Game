using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallMove : MonoBehaviour
{
    public ballscript ballscript;

    public GameObject Ball, Pitchermound, BatterBox, Bat, foul1, foul2,HOMERUNimage,HITimage,FOULimage,OUTimage,STRIKEimage;

    public GameObject Score,BSOcount,ScoreCanvas, Settingpanel, setting;

    public GameObject Startmenu,ModeSelect,Titlelogo,Bottoncanvas,Result,Reloadgame;

    public int Status = 0;

    public Text YourScore;

    float ballspeed = 1.5f;

    float time = 0.0f;

    float pitchtime = 0.0f;

    float speed = 0.01f;

    int ballmovelevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartMode();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.W))
        {
            Ball.transform.position = Pitchermound.transform.position;
            Rigidbody2D rb = Ball.GetComponent<Rigidbody2D>();
            Hideimage();
            Vector3 force = (BatterBox.transform.position - Pitchermound.transform.position) / ballspeed;
            rb.velocity = (force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Bat.transform.Rotate(new Vector3(0, 0, -360 * Time.deltaTime));
            if (Bat.transform.localEulerAngles.z < 180)
            {
                Bat.transform.localEulerAngles = new Vector3(0, 0, 180);
            }

        }
        else
        {
            Bat.transform.Rotate(new Vector3(0, 0, 360 * Time.deltaTime));
            if (Bat.transform.localEulerAngles.z < 180)
            {
                Bat.transform.localEulerAngles = new Vector3(0,0,0);
            }
        }

       
        
 
    }
    void Hideimage()
    {
        HITimage.SetActive(false);
        HOMERUNimage.SetActive(false);
        OUTimage.SetActive(false);
        FOULimage.SetActive(false);
        STRIKEimage.SetActive(false);
    }

    public void StartMode()
    {
        ScoreCanvas.SetActive(false);
        Settingpanel.SetActive(true);
        BSOcount.SetActive(false);
        Score.SetActive(false);
        Ball.SetActive(false);
        ModeSelect.SetActive(false);
        Titlelogo.SetActive(true);
        Startmenu.SetActive(true);
        Bottoncanvas.SetActive(true);
        Status = 1;

    }
    public void GameMenu()
    {
        Titlelogo.SetActive(false);
        Bottoncanvas.SetActive(false);
        ModeSelect.SetActive(true);
        Startmenu.SetActive(false);
    }
    public void Gamestart()
    {
        ScoreCanvas.SetActive(true);
        Settingpanel.SetActive(false);
        BSOcount.SetActive(true);
        Score.SetActive(true);
        Ball.SetActive(true);
        Titlelogo.SetActive(false); 
        ModeSelect.SetActive(false);
        Startmenu.SetActive(false);
        Bottoncanvas.SetActive(true);
        Status = 2;
    }
    public void ResultMenu()
    {
        ScoreCanvas.SetActive(false);
        Settingpanel.SetActive(true);
        BSOcount.SetActive(false);
        Score.SetActive(false);
        Ball.SetActive(false);
        Result.SetActive(true);
        setting.SetActive(false);
        Bottoncanvas.SetActive(false);
        Reloadgame.SetActive(true);
        YourScore.text = "Your Score:" + ballscript.Scorecount.ToString();
    }
}


