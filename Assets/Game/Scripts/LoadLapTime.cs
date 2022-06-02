using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
	public int MinuteCount;
	public int SecondCount;
	public float MilliCount;
	public GameObject MinuteBest;
	public GameObject SecondBest;
	public GameObject MiliSecBest;

	void Start()
	{

		MinuteCount = PlayerPrefs.GetInt("MinSave");
		SecondCount = PlayerPrefs.GetInt("SecSave");
		MilliCount = PlayerPrefs.GetFloat("MilliSave");


		MinuteBest.GetComponent<Text>().text = "" + MinuteCount + ":";
		SecondBest.GetComponent<Text>().text = "" + SecondCount + ".";
		MiliSecBest.GetComponent<Text>().text = "" + MilliCount;

	}
}
