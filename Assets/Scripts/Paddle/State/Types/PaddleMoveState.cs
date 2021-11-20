using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �е� �̵� ���� Ŭ����
/// </summary>
public class PaddleMoveState : PaddleState
{
    //�ڽ� �ν��Ͻ��Դϴ�.
    private static PaddleMoveState paddleMoveState = new PaddleMoveState();

    /// <summary>
    /// ĸ��ȭ�� �ڽ� �ν��Ͻ��� �����ɴϴ�.
    /// </summary>
    /// <returns>�ڽ� �ν��Ͻ� �ּڰ�</returns>
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
