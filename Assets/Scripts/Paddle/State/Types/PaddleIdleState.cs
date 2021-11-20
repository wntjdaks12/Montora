using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �е� ���� ���� Ŭ����
/// </summary>
public class PaddleIdleState : PaddleState
{
    //�ڽ� �ν��Ͻ��Դϴ�.
    private static PaddleIdleState paddleIdleState = new PaddleIdleState();

    /// <summary>
    /// ĸ��ȭ�� �ڽ� �ν��Ͻ��� �����ɴϴ�.
    /// </summary>
    /// <returns>�ڽ� �ν��Ͻ� �ּڰ�</returns>
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
