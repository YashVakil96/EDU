using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    private Camera cam;
    public BallManager bm;
    private void Start()
    {
        cam = Camera.main;
        
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
    
    
}