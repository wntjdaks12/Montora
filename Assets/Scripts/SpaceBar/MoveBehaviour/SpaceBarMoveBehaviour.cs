using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스트레티지 패턴 - 스페이스 바 이동 인터페이스
public interface SpaceBarMoveBehaviour
{
    public void Move(Transform ts, Vector3 pos, float lerpSpd);
}
