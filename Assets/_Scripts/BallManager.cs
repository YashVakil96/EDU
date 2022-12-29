using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public List<GameObject> balls;
    public int offsetCounter=0;
    public int ballCount;

    private void Start()
    {
        for (int i = 0; i < ballCount; i++)
        {
            var ball = Instantiate(ballPrefab, transform);
            ball.GetComponent<Follower>().offset = offsetCounter;
            offsetCounter += 2;
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            balls.Add(transform.GetChild(i).gameObject);
        }

        foreach (var ball in balls)
        {
            ball.SetActive(false);
        }
    }

    public void ShowBalls()
    {
        foreach (var ball in balls)
        {
            ball.SetActive(true);
        }
    }

    public void HideBalls()
    {
        foreach (var ball in balls)
        {
            ball.SetActive(false);
        }
    }
}