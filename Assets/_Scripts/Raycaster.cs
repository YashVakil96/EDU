using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{

    public LightManager lightManager;

    public static float lightIntensity;
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * 1000, Color.red, 0);
        RaycastHit hitobj;
        var hit = Physics.Raycast(transform.position, transform.up * 1000,out hitobj);
        if (hit)
        {
            lightIntensity = hitobj.transform.GetComponent<BoxIntensity>().lightIntensity;

            lightManager.SetLight(lightIntensity);
        }
    }
}