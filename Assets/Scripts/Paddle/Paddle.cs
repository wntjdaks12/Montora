using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �е�
/// </summary>
public class Paddle : MonoBehaviour
{
    // �е�� ����, �������� �������̸� �ռ������Դϴ�.
    private PaddleState state;
    private PaddleMoveBehaviour moveBehaviour;

    private void Awake()
    {
        state = PaddleIdleState.GetInstance();
        moveBehaviour = new PaddleHorizontalMove();
    }

    /// <summary>
    /// �е��� ���¸� �����մϴ�.
    /// </summary>
    /// <param name="state">���ο� ����</param>
    public void SetState(PaddleState state)
    {
        this.state = state;
    }
    /// <summary>
    /// �е��� �������� �����մϴ�.
    /// </summary>
    /// <param name="moveBehaviour">���ο� ������</param>
    public void SetMoveBehaviour(PaddleMoveBehaviour moveBehaviour)
    {
        this.moveBehaviour = moveBehaviour;
    }

    /// <summary>
    /// �е��� ������ �Ӵϴ�.
    /// </summary>
    public void Idle()
    {
        state?.Idle(this);
    }

    /// <summary>
    /// �е��� �����Դϴ�.
    /// </summary>
    /// <param name="pos">�̵��� ������ ��</param>
    public void Move(Vector3 pos)
    {
        moveBehaviour?.Move(gameObject, Camera.main.ScreenToWorldPoint(pos), 0.3f);
        state?.Move(this);
    }
}
