using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 패들
/// </summary>
public class Paddle : MonoBehaviour
{
    // 패들 작동에 있어 퍼사드로 묶은 요소들입니다.
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
    /// 패들의 상태를 변경합니다.
    /// </summary>
    /// <param name="state">새로운 상태</param>
    public void SetState(PaddleState state)
    {
        this.state = state;
    }
    /// <summary>
    /// 패들의 움직임 행위를 변경합니다.
    /// </summary>
    /// <param name="moveBehaviour">새로운 움직임 행위</param>
    public void SetMoveBehaviour(PaddleMoveBehaviour moveBehaviour)
    {
        this.moveBehaviour = moveBehaviour;
    }

    /// <summary>
    /// 패들을 멈춥니다.
    /// </summary>
    public void Stop()
    {
        state?.Idle(this);
    }

    /// <summary>
    /// 패들을 작동시킵니다.
    /// </summary>
    /// <param name="pos">이동할 포지션 값</param>
    public void Operate(Vector3 pos)
    {
        moveBehaviour?.Move(gameObject, Camera.main.ScreenToWorldPoint(pos), 0.3f);
        state?.Move(this);

        paddleSlider?.setValue(pos.x / Screen.width);
    }
}
