using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;


    public GameObject LapTimeBox;


    public GameObject LapCounter;
    public GameObject RaceFinish;

    public int LapsDone;
    public float RawTime;


    void Update()
    {
        
        if (LapsDone < 1)
        {
            LapsDone += 1;
            LapCounter.GetComponent<Text>().text = "" + LapsDone;
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime <= RawTime)
        {
            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
            }

            if (LapTimeManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
            }

            MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MiliCount;


            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MiliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MiliCount = 0;
            LapTimeManager.RawTime = 0;

            

            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
