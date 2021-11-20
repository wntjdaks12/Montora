using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������Ʈ ���� - �е� �������̽�
public interface PaddleState
{
    /// <summary>
    /// �е��� ���¸� �̵����� �ٲߴϴ�.
    /// </summary>
    /// <param name="paddle">�е� �ּڰ�</param>
    public void Idle(Paddle paddle);

    /// <summary>
    /// �е��� ���¸� �̵����� �ٲߴϴ�.
    /// </summary>
    /// <param name="paddle">�е� �ּڰ�</param>
    public void Move(Paddle paddle);
}
