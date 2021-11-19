using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������Ʈ ���� - �����̽� �� Idle ���� Ŭ����
public class SpaceBarIdleState : SpaceBarState
{
    /*------------------------------------------------------------------
    This �ν��Ͻ�                                                        */
    private static SpaceBarIdleState spaceBarIdleState = new SpaceBarIdleState();
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    ĸ��ȭ�� This �ν��Ͻ� Get ���                                       */
    public static SpaceBarIdleState GetInstance()
    {
        return spaceBarIdleState;
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    ���� ����                                                           */
    public void Idle(SpaceBar spaceBar)
    {
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    ���� ���¿��� Move�� ��ü                                            */
    public void Move(SpaceBar spaceBar)
    {
        spaceBar.SetState(SpaceBarMoveState.GetInstance());
    }
    //------------------------------------------------------------------
}
