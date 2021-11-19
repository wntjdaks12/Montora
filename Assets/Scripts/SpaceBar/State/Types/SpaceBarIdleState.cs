using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스테이트 패턴 - 스페이스 바 Idle 상태 클래스
public class SpaceBarIdleState : SpaceBarState
{
    /*------------------------------------------------------------------
    This 인스턴스                                                        */
    private static SpaceBarIdleState spaceBarIdleState = new SpaceBarIdleState();
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    캡슐화된 This 인스턴스 Get 방식                                       */
    public static SpaceBarIdleState GetInstance()
    {
        return spaceBarIdleState;
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    현재 상태                                                           */
    public void Idle(SpaceBar spaceBar)
    {
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    현재 상태에서 Move로 교체                                            */
    public void Move(SpaceBar spaceBar)
    {
        spaceBar.SetState(SpaceBarMoveState.GetInstance());
    }
    //------------------------------------------------------------------
}
