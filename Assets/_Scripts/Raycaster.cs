using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * 1000, Color.red, 0);
        var hit = Physics.Raycast(transform.position, transform.up * 1000);
        if (hit)
        {
            Debug.Log(hit);
        }
    }
}