using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallUpMoveState : BallState
{
    private static BallUpMoveState ballUpMoveState = new BallUpMoveState();

    public static BallUpMoveState GetInstance()
    {
        return ballUpMoveState;
    }

    public void UpMove(Ball ball)
    {
    }

    public void DownMove(Ball ball)
    {
        ball.setState(BallDownMoveState.GetInstance());

        ball.DirDown();
    }
}
