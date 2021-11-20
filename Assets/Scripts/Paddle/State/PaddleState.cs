using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스테이트 패턴 - 패들 인터페이스
public interface PaddleState
{
    /// <summary>
    /// 패들의 상태를 이동으로 바꿉니다.
    /// </summary>
    /// <param name="paddle">패들 주솟값</param>
    public void Idle(Paddle paddle);

    /// <summary>
    /// 패들의 상태를 이동으로 바꿉니다.
    /// </summary>
    /// <param name="paddle">패들 주솟값</param>
    public void Move(Paddle paddle);
}
