using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MiliCount;
    public static string MiliDisplay;
    public static float RawTime;


    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MiliBox;

    void Update()
    {
        MiliCount += Time.deltaTime * 10;
        MiliDisplay = MiliCount.ToString("F0");
        MiliBox.GetComponent<Text>().text=""+MiliDisplay;

        if(MiliCount >= 10)
        {
            MiliCount = 0;
            SecondCount += 1;
        }

        if(SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
        }

        if(SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }
        if(MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
    }
}
