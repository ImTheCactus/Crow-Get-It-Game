using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveLight : MonoBehaviour
{
    private Light directionalLight;
    private bool changeLight = false;
    private bool isDark = false;
    private float transitionSpeed = 0.01f;
    private float minIntensity = 0.01f;
    private float maxIntensity = 2.5f;

    private void Start()
    {
        directionalLight = GetComponentInChildren<Light>();
        isDark = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            changeLight = true;
        }
    }

    private void ChangeLight()
    {
        if (changeLight == true)
        {
            if (directionalLight.intensity > minIntensity && isDark == false)
            {
                for (int i = 0; i < maxIntensity; i++)
                {
                    directionalLight.intensity -= transitionSpeed;
                    if (directionalLight.intensity <= minIntensity)
                    {
                        directionalLight.intensity = minIntensity;
                        changeLight = false;
                        isDark = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minIntensity; i++)
                {
                    directionalLight.intensity += transitionSpeed;
                    if (directionalLight.intensity >= maxIntensity)
                    {
                        directionalLight.intensity = maxIntensity;
                        changeLight = false;
                        isDark = false;
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeLight();
    }
}