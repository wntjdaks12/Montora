using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public delegate void scoreDelegate(int score);
    public static event scoreDelegate scoreEvent;

    public UnityEvent gameClearEvent, gameOverEvent;

    private int ballNum, brickNum, score;

    private void Awake()
    {
        ballNum = 0;
        brickNum = 0;
    }

    private void Start()
    {
        Score = 0;
    }

    public int BallNum
    {
        get { return ballNum; }
        set
        {
            ballNum = value;

            if (ballNum == 0)
                gameOverEvent?.Invoke();
        }
    }

    public int BrickNum
    {
        get { return brickNum; }
        set
        {
            brickNum = value;

            if (brickNum == 0)
            {
                gameClearEvent?.Invoke();
            }
        } 
    }

    public int Score 
    { 
        get { return score; }

        set
        {
            score = value;

            scoreEvent?.Invoke(score);
        }
    }
}
