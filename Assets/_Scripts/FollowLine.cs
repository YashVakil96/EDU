using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Networking;

public class FollowLine : MonoBehaviour
{
    public LineRenderer line;
    public float moveSpeed;
    public Vector3[] positions = new Vector3[10];
    private int index;
    public bool isMoving;

    private void Start()
    {
        positions = new Vector3[line.positionCount];
        line.GetPositions(positions);
        index = 1;
    }

    private void Update()
    {
        Debug.Log(index);
        if (index >= positions.Length)
        {
            index = 0;
        }
        if (!isMoving)
        {
            Move();
            Debug.Log(index);
        }
    }


    void Move()
    {
        isMoving = true;
        transform.DOLocalMove(positions[index], 1).OnComplete(() =>
        {
            index++;
            isMoving = false;
        });
    }
}