using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �е�
/// </summary>
public class Paddle : MonoBehaviour
{
    // �е� �۵��� �־� �ۻ��� ���� ��ҵ��Դϴ�.
    private PaddleState state;
    private PaddleMoveBehaviour moveBehaviour;
    [SerializeField]
    private PaddleSlider paddleSlider;

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
    /// �е��� ������ ������ �����մϴ�.
    /// </summary>
    /// <param name="moveBehaviour">���ο� ������ ����</param>
    public void SetMoveBehaviour(PaddleMoveBehaviour moveBehaviour)
    {
        this.moveBehaviour = moveBehaviour;
    }

    /// <summary>
    /// �е��� ����ϴ�.
    /// </summary>
    public void Stop()
    {
        state?.Idle(this);
    }

    /// <summary>
    /// �е��� �۵���ŵ�ϴ�.
    /// </summary>
    /// <param name="pos">�̵��� ������ ��</param>
    public void Operate(Vector3 pos)
    {
        moveBehaviour?.Move(gameObject, Camera.main.ScreenToWorldPoint(pos), 0.3f);
        state?.Move(this);

        paddleSlider?.setValue(pos.x / Screen.width);
    }
}
