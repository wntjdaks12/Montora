using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 패들 멈춤 상태 클래스
/// </summary>
public class PaddleIdleState : PaddleState
{
    //자신 인스턴스입니다.
    private static PaddleIdleState paddleIdleState = new PaddleIdleState();

    /// <summary>
    /// 캡슐화된 자신 인스턴스를 가져옵니다.
    /// </summary>
    /// <returns>자신 인스턴스 주솟값</returns>
    public static PaddleIdleState GetInstance()
    {
        return paddleIdleState;
    }

    public void Idle(Paddle paddle)
    {
    }

    public void Move(Paddle paddle)
    {
        paddle.SetState(PaddleMoveState.GetInstance());
    }
}
