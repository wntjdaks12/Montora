using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스트레티지 패턴 - 패들 이동 인터페이스
public interface PaddleMoveBehaviour
{
    /// <summary>
    /// 이동 시 필요한 요소들입니다.
    /// </summary>
    /// <param name="paddleObj">패들 오브젝트</param>
    /// <param name="pos">이동할 포지션 값</param>
    /// <param name="lerpSpd">이동 시 부드러운 속도</param>
    public void Move(GameObject paddleObj, Vector3 pos, float lerpSpd);
}
