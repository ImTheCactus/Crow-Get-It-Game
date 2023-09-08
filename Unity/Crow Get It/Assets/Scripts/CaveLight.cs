using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveLight : MonoBehaviour
{
    private Light directionalLight;
    public bool changeLight = false;
    public float intensitySpeed = 1f;
    public float minIntensity = 0f;
    public float maxIntensity = 2.5f;
    private bool isDark = false;
    
    float startTime;

    private void Start()
    {
        directionalLight = GetComponentInChildren<Light>();
        startTime = Time.time;
        changeLight = false;
        maxIntensity = 2.5f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            changeLight = true;
        }
    }


    private void Update()
    {
        if(changeLight == true)
        {
            if (isDark == false)
            {
                directionalLight.intensity = minIntensity;
                isDark = true;
                changeLight = false;
            }
            else if(isDark == true)
            {
                directionalLight.intensity = maxIntensity;
                isDark = false;
                changeLight = false;
            }
        }
    }
}