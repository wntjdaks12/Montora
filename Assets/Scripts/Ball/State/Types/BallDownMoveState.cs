using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDownMoveState : BallState
{
    private static BallDownMoveState ballDownMoveState = new BallDownMoveState();

    public static BallDownMoveState GetInstance()
    {
        return ballDownMoveState;
    }

    public void UpMove(Ball ball)
    {
        ball.setState(BallUpMoveState.GetInstance());

        ball.DirUp();
    }

    public void DownMove(Ball ball)
    {
    }
}
