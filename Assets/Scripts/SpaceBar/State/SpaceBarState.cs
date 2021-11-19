using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스테이트 패턴 - 스페이스 바 인터페이스
public interface SpaceBarState
{
    public void Idle(SpaceBar spaceBar);
    public void Move(SpaceBar spaceBar);
}
