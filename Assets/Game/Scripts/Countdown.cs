using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject LapTimer;
    public VehicleControl vehicleControl;
    public GameObject DreamCar01;
    

    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        CountDown.SetActive(true);


        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        CountDown.SetActive(true);


        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        CountDown.SetActive(true);


        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        LapTimer.SetActive(true);
        vehicleControl.activeControl = true;
        DreamCar01.GetComponent<CarAIControl>().enabled = true;
    }


}
