using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 패들
/// </summary>
public class Paddle : MonoBehaviour
{
    // 패들와 상태, 움직임은 의존적이며 합성관계입니다.
    private PaddleState state;
    private PaddleMoveBehaviour moveBehaviour;

    private void Awake()
    {
        state = PaddleIdleState.GetInstance();
        moveBehaviour = new PaddleHorizontalMove();
    }

    /// <summary>
    /// 패들의 상태를 변경합니다.
    /// </summary>
    /// <param name="state">새로운 상태</param>
    public void SetState(PaddleState state)
    {
        this.state = state;
    }
    /// <summary>
    /// 패들의 움직임을 변경합니다.
    /// </summary>
    /// <param name="moveBehaviour">새로운 움직임</param>
    public void SetMoveBehaviour(PaddleMoveBehaviour moveBehaviour)
    {
        this.moveBehaviour = moveBehaviour;
    }

    /// <summary>
    /// 패들을 가만히 둡니다.
    /// </summary>
    public void Idle()
    {
        state?.Idle(this);
    }

    /// <summary>
    /// 패들을 움직입니다.
    /// </summary>
    /// <param name="pos">이동할 포지션 값</param>
    public void Move(Vector3 pos)
    {
        moveBehaviour?.Move(gameObject, Camera.main.ScreenToWorldPoint(pos), 0.3f);
        state?.Move(this);
    }
}
