using System;
using System.Collections;
using System.Collections.Generic;
using PathCreation;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public PathCreator path;
    public float Speed;
    public float offset;
    public float distanceTravelled;
    public static bool On;


    private void Start()
    {
        Speed = 5;
        distanceTravelled = offset;
        path = FindObjectOfType<PathCreator>();
    }

    private void Update()
    {
        if (On)
        {
            distanceTravelled += Speed * Time.deltaTime;
            transform.position = path.path.GetPointAtDistance(distanceTravelled);
        }
    }
}
