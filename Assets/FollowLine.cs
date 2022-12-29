using System;
using System.Collections.Generic;
using UnityEngine;

public class FollowLine : MonoBehaviour
{
    public List<Transform> pathToFollow;
    public LineRenderer line;

    private void Start()
    {
        Debug.Log(line.GetPositions(new Vector3[10]));

    }
}
