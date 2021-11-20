using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 패들 이동 상태 클래스
/// </summary>
public class PaddleMoveState : PaddleState
{
    //자신 인스턴스입니다.
    private static PaddleMoveState paddleMoveState = new PaddleMoveState();

    /// <summary>
    /// 캡슐화된 자신 인스턴스를 가져옵니다.
    /// </summary>
    /// <returns>자신 인스턴스 주솟값</returns>
    public static PaddleMoveState GetInstance()
    {
        return paddleMoveState;
    }

    public void Idle(Paddle paddle)
    {
        paddle.SetState(PaddleIdleState.GetInstance());
    }

    public void Move(Paddle paddle)
    {
    }
}
