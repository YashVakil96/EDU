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


    private void Start()
    {
        distanceTravelled = offset;
    }

    private void Update()
    {
        distanceTravelled += Speed * Time.deltaTime;
        transform.position = path.path.GetPointAtDistance(distanceTravelled);
    }
}
