using UnityEngine;
using System.Collections;

public class zegarek : MonoBehaviour
{

    public float fsek = 0;
    public int sek = 0;
    public int minuty = 0;
    public int godz = 0;
    public int godz2 = 0;
    public int tryb24 = 0;

    public string ssek;
    public string sminuty;
    public string sgodz;

    // Use this for initialization 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            if (tryb24 == 0)
            {
                tryb24 = 1;
                godz = godz2;
            }
            else
            {
                tryb24 = 0;
                godz = godz2;
            }
        }


        fsek += Time.deltaTime;
        sek = (int)fsek;

        if (sek >= 60)
        {
            minuty += 1;
            fsek -= 60;
        }

        if (minuty >= 60)
        {
            godz += 1;
            godz2 += 1;
            minuty -= 60;
        }

        if (godz >= 12 + tryb24 * 12)
        {
            godz = godz2 - 12 + 12 * tryb24;
        }

        if (godz2 >= 24)
        {
            godz2 = 0;
        }
        else

            if (sek < 10)
            {
                ssek = "0" + sek.ToString();
            }
            else
                ssek = sek.ToString();

        if (minuty < 10)
        {
            sminuty = "0" + minuty.ToString();
        }
        else
            sminuty = minuty.ToString();

        if (godz < 10)
        {
            sgodz = "0" + godz.ToString();
        }
        else
            sgodz = godz.ToString();

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), sgodz + ":" + sminuty + ":" + ssek);
    }
}