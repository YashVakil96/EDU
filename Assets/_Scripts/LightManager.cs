using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    private Camera cam;
    public BallManager bm;
    public GameObject lightObj;

    private void Start()
    {
        cam = Camera.main;
        lightObj.GetComponent<Renderer>().material.SetColor("_EmissionColor",Color.red*-10);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name.Equals("Switch on"))
                {
                    bm.ShowBalls();
                    Follower.On = true;
                }
                else if (hit.transform.name.Equals("Switch off"))
                {
                    bm.HideBalls();
                    Follower.On = false;
                }
            }
        }
    }

    public void SetLight(float intensity)
    {
        if (Follower.On)
        {
            lightObj.GetComponent<Renderer>().material.SetColor("_EmissionColor",Color.red * (intensity));    
        }
        else
        {
            lightObj.GetComponent<Renderer>().material.SetColor("_EmissionColor",Color.red*-10);
        }
        
    }
}