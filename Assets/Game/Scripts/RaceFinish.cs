using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject CompleteTrig;


	void OnTriggerEnter()
	{
        this.GetComponent<BoxCollider>().enabled = false;
		MyCar.GetComponent<VehicleControl>().activeControl = false;
        CompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
		MyCar.GetComponent<VehicleControl>().speed = 0.0f;
		FinishCam.SetActive(true);
		ViewModes.SetActive(false);
		MyCar.GetComponent<CarController>().enabled = false;
        //MyCar.SetActive(true);
		
		
	}
}
