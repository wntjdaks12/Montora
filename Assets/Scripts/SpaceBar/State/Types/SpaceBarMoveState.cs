using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������Ʈ ���� - �����̽� �� Move ���� Ŭ����
public class SpaceBarMoveState : SpaceBarState
{
    /*------------------------------------------------------------------
    This �ν��Ͻ�                                                        */
    private static SpaceBarMoveState spaceBarMoveState = new SpaceBarMoveState();
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    ĸ��ȭ�� This �ν��Ͻ� Get ���                                       */
    public static SpaceBarMoveState GetInstance()
    {
        return spaceBarMoveState;
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    ���� ���¿��� Idle�� ��ü                                              */
    public void Idle(SpaceBar spaceBar)
    {
        spaceBar.SetState(SpaceBarIdleState.GetInstance());
    }
    //------------------------------------------------------------------

    /*------------------------------------------------------------------
    ���� ����                                                            */
    public void Move(SpaceBar spaceBar)
    {
    }
    //------------------------------------------------------------------
}
