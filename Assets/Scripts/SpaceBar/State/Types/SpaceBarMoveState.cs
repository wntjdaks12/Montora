using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스테이트 패턴 - 스페이스 바 Move 상태 클래스
public class SpaceBarMoveState : SpaceBarState
{
    /*------------------------------------------------------------------
    This 인스턴스                                                        */
    private static SpaceBarMoveState spaceBarMoveState = new SpaceBarMoveState();
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    캡슐화된 This 인스턴스 Get 방식                                       */
    public static SpaceBarMoveState GetInstance()
    {
        return spaceBarMoveState;
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    현재 상태에서 Idle로 교체                                              */
    public void Idle(SpaceBar spaceBar)
    {
        spaceBar.SetState(SpaceBarIdleState.GetInstance());
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    현재 상태                                                            */
    public void Move(SpaceBar spaceBar)
    {
    }
    //------------------------------------------------------------------
}
