using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
    public GameObject Pitchermound;
    public GameObject HITimage;
    public GameObject HOMERUNimage, OUTimage, FOULimage, STRIKEimage;
    public GameObject FirstBase, SecondBase, ThirdBase;
    public GameObject STRIKE1, STRIKE2, OUT1, OUT2;
    public GameObject ScoreCanvas, Settingpanel, setting;
    public BallMove BallMove;
    int[] Base = new int[3];
    int Ballcount = 0;
    int OUTcount = 0;
    public static int Scorecount = 0;
    public int Inningcount = 1;
    public int EndInning = 1;
    // Start is called before the first frame update
    void Start()
    {
        Base[0] = 0;
        Base[1] = 0;
        Base[2] = 0;
        Inningcount = 1;
        Scorecount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {

        if (HITimage.activeSelf || HOMERUNimage.activeSelf
           || OUTimage.activeSelf || FOULimage.activeSelf || STRIKEimage.activeSelf)
        {

        }

        else if (collision2D.gameObject.tag == "foulzone")
        {
            positionreset();
            Invoke("Hideimage", 2);
            Activeimage(FOULimage);
            if (Ballcount <= 1)
            {
                Ballcount += 1;
            }

        }

        else if (collision2D.gameObject.name == "foulzone")
        {
            positionreset();
            Invoke("Hideimage", 2);
            Activeimage(FOULimage);
            if (Ballcount <= 1)
            {
                Ballcount += 1;
            }
        }
        else if (collision2D.gameObject.name == "fairzone")
        {
            positionreset();
            Invoke("Hideimage", 2);

        }

        else if (collision2D.gameObject.tag == "OUT")
        {
            Ballcount = 0;
            positionreset();
            Invoke("Hideimage", 2);
            Activeimage(OUTimage);
            OUTcount += 1;
            if (OUTcount >= 3)
            {
                OUTcount = 0;
                basereset();
                Inningcount += 1;
            }

        }

        else if (collision2D.gameObject.tag == "1BH")
        {
            Ballcount = 0;
            positionreset();
            Activeimage(HITimage);
            Invoke("Hideimage", 2);
            if (Base[2] == 1)
            {
                Scorecount += 1;
                Base[2] = 0;
            }
            Base[2] = Base[1];
            Base[1] = 0;
            Base[1] = Base[0];
            Base[0] = 0;
            Base[0] = 1;
        }

        else if (collision2D.gameObject.tag == "2BH")
        {
            Ballcount = 0;
            positionreset();
            Activeimage(HITimage);
            Invoke("Hideimage", 2);

            if (Base[2] == 1)
            {
                Scorecount += 1;
                Base[2] = 0;
            }
            if (Base[1] == 1)
            {
                Scorecount += 1;
                Base[1] = 0;
            }
            Base[2] = Base[0];
            Base[0] = 0;
            Base[1] = 1;
        }

        else if (collision2D.gameObject.tag == "3BH")
        {
            Ballcount = 0;
            positionreset();
            Activeimage(HITimage);
            Invoke("Hideimage", 2);
            if (Base[2] == 1)
            {
                Scorecount += 1;
                Base[2] = 0;
            }
            if (Base[1] == 1)
            {
                Scorecount += 1;
                Base[1] = 0;
            }
            if (Base[0] == 1)
            {
                Scorecount += 1;
                Base[0] = 0;
            }
            Base[2] = 1;
        }

        else if (collision2D.gameObject.tag == "HOMERUN")
        {
            Ballcount = 0;
            positionreset();
            Activeimage(HOMERUNimage);
            Invoke("Hideimage", 2);
            Scorecount += 1;
            if (Base[2] == 1)
            {
                Scorecount += 1;
                Base[2] = 0;
            }
            if (Base[1] == 1)
            {
                Scorecount += 1;
                Base[1] = 0;
            }
            if (Base[0] == 1)
            {
                Scorecount += 1;
                Base[0] = 0;
            }
        }

        else if (collision2D.gameObject.name == "strikezone")
        {
            positionreset();
            Invoke("Hideimage", 2);
            Activeimage(STRIKEimage);
            Ballcount += 1;
            if (Ballcount >= 3)
            {
                Ballcount = 0;
                OUTcount += 1;
            }
            if (OUTcount >= 3)
            {
                OUTcount = 0;
                basereset();
                Inningcount += 1;
            }

        }
        if (Base[0] == 1)
        {
            FirstBase.SetActive(true);
        }
        else
        {
            FirstBase.SetActive(false);
        }

        if (Base[1] == 1)
        {
            SecondBase.SetActive(true);
        }
        else
        {
            SecondBase.SetActive(false);
        }

        if (Base[2] == 1)
        {
            ThirdBase.SetActive(true);
        }
        else
        {
            ThirdBase.SetActive(false);
        }
        void positionreset()
        {
            GetComponent<Transform>().position = Pitchermound.transform.position;

            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);

        }

        if (OUTcount == 1)
        {
            OUT1.SetActive(true);
        }

        else if (OUTcount == 2)
        {
            OUT1.SetActive(true);
            OUT2.SetActive(true);
        }

        else
        {
            OUT1.SetActive(false);
            OUT2.SetActive(false);
        }

        if (Ballcount == 1)
        {
            STRIKE1.SetActive(true);
        }

        else if (Ballcount == 2)
        {
            STRIKE1.SetActive(true);
            STRIKE2.SetActive(true);
        }

        else
        {
            STRIKE1.SetActive(false);
            STRIKE2.SetActive(false);
        }
        if (EndInning == 3)
        {
            if (Inningcount == 4)
            {
                BallMove.ResultMenu();
            }
        }
        else if (EndInning == 6)
        {
            if (Inningcount == 7)
            {
                BallMove.ResultMenu();
            }
        }
        else if (EndInning == 9)
        {
            if (Inningcount == 10)
            {
                BallMove.ResultMenu();
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
    void Activeimage(GameObject image)
    {
        if (!HITimage.activeSelf && !HOMERUNimage.activeSelf
           && !OUTimage.activeSelf && !FOULimage.activeSelf && !STRIKEimage.activeSelf)
        {
            image.SetActive(true);
        }

    }

    void basereset()
    {
        Base[0] = 0;
        Base[1] = 0;
        Base[2] = 0;
    }

    public void SettingMode()
    {
        ScoreCanvas.SetActive(false);
        Settingpanel.SetActive(true);
        setting.SetActive(true);
    }

    public void PlayMode()
    {
        ScoreCanvas.SetActive(true);
        Settingpanel.SetActive(false);
        setting.SetActive(false);
    }
    public void Backtostart()
    {
        
        setting.SetActive(false);
    }

   
}
