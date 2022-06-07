using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public enum Weather { NONE, SUNNY, RAIN, SNOW};

    public Weather currentWeather;

    public ParticleSystem rain;

    [Header("Time Settings")]

    public float weatherTime;
    public float rainTime;
    public float sunnyTime;

    public int currentTime;



    private void Start()
    {
        this.currentWeather = Weather.RAIN;
        this.currentTime = 1;

        this.weatherTime = this.rainTime;
    }

    public void ChangeWeather(Weather weatherType)
    {
        if(weatherType != currentWeather)
        {
            switch (weatherType)
            {
                case Weather.RAIN:
                    currentWeather = Weather.RAIN;
                    this.rain.Play();
                    break;
                case Weather.SUNNY:
                    currentWeather = Weather.SUNNY;
                    this.rain.Stop();
                    break;
            }
        }
    }

    private void Update()
    {
        this.weatherTime -= Time.deltaTime;

        if (this.currentWeather == Weather.RAIN)
        {
            

            if (this.weatherTime <=0f)
            {
                ChangeWeather(Weather.SUNNY);
                this.weatherTime = this.sunnyTime;
            }
        }

        if (this.currentWeather == Weather.SUNNY)
        {


            if (this.weatherTime <= 0f)
            {
                ChangeWeather(Weather.RAIN);
                this.weatherTime = this.rainTime;
            }
        }
    }
}
